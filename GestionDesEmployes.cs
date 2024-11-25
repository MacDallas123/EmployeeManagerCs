using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;

namespace EngineeringProjet
{
			
    public partial class GestionDesEmployes : DevExpress.XtraEditors.XtraForm
    {
        public GestionDesEmployes()
        {
            InitializeComponent();           
        }

        public BindingSource EmployeeSource
        {
            get { return EmployeeBindingSource; }
            set { EmployeeBindingSource = value; }
        }


        public string TableName
        {
            get { return UserProfil.Text; }
            set { UserProfil.Text = value; }
        }

        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Alfred-Remy KOUMNDA\Documents\Visual Studio 2013\Projects\EnterpriseManagement\EngineeringProjet\ManagementProject.mdf';Integrated Security=True;Connect Timeout=30");
        //Data Source=.\SQLEXPRESS;Initial Catalog=EmDatabase;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=EmDatabase;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader DataReader;
        int EmployeeNumber = 0;

        private void FillCombo()
        {
            cmd = new SqlCommand("SELECT * FROM " + TableName + "PostTable ORDER BY nom;", con);
            try
            {
                con.Open();
                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    string sName = DataReader.GetString(1);
                    EmployeePost.Items.Add(sName);
                }               
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void TakeMaxId()
        {
            cmd = new SqlCommand("SELECT * FROM " + TableName + "EmployeeTable ORDER BY id", con);
            try
            {
                con.Open();
                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    int sId = DataReader.GetInt32(0);
                    max.Text = sId.ToString();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void Actualiser()
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + TableName + "EmployeeTable ORDER BY nom", con);
            sda.Fill(tbl);
            EmployeeBindingSource.DataSource = tbl;
            ListeDesEmployés.DataSource = EmployeeBindingSource;

            EmployeeNumber = EmployeeBindingSource.Count;
            EmployeeNb.Text = EmployeeNumber.ToString();
        }

        private void GestionDesEmployes_Load(object sender, EventArgs e)
        {      
            con.Open();
            try
            {
                cmd = new SqlCommand("CREATE TABLE " + TableName + "EmployeeTable ( Id INT NOT NULL, Nom NVARCHAR(50) NOT NULL, Prenom NVARCHAR(50) NOT NULL, Sexe NVARCHAR(10) NOT NULL, Date DATETIME NOT NULL, Poste NVARCHAR(50) NOT NULL, Contact NVARCHAR(50) NOT NULL, Image TEXT NULL, Stagiaire NVARCHAR(10) NOT NULL, Fin DATETIME NULL, Salaire INT NOT NULL, CONSTRAINT PK_" + TableName + "EmployeeTable PRIMARY KEY CLUSTERED (Id ASC))", con);
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Création de la liste des employés : " + TableName + "EmployeeTable du nouveau profil créée");
                }                

            }
            catch(Exception)
            {
                //Rien ne se passe...
            }

            try
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + TableName + "EmployeeTable ORDER BY nom", con);
                sda.Fill(tbl);
                EmployeeBindingSource.DataSource = tbl;
                ListeDesEmployés.DataSource = EmployeeBindingSource;
                gridBand1.Columns[0].Visible = false;
                gridBand1.Columns[7].Visible = false;
                gridBand1.Columns[8].Visible = false;
                gridBand1.Columns[9].Visible = false;

                EmployeeId.DataBindings.Add("text", EmployeeBindingSource, "Id");
                EmployeeName.DataBindings.Add("text", EmployeeBindingSource, "Nom");
                EmployeeSurName.DataBindings.Add("text", EmployeeBindingSource, "Prenom");
                EmployeeStartDate.DataBindings.Add("text", EmployeeBindingSource, "Date");
                EmployeePost.DataBindings.Add("text", EmployeeBindingSource, "Poste");
                EmployeeContact.DataBindings.Add("text", EmployeeBindingSource, "Contact");
                ImagePath.DataBindings.Add("text", EmployeeBindingSource, "Image");
                EmployeeStageSalary.DataBindings.Add("text", EmployeeBindingSource, "Salaire");

                reportGender.DataBindings.Add("text", EmployeeBindingSource, "Sexe");

                EmployeeNumber = EmployeeBindingSource.Count;
                EmployeeNb.Text = EmployeeNumber.ToString();

                ImagePath.Hide();

                label11.Hide();
                max.Hide();
                reportGender.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
            con.Close();
            /***********/
            TakeMaxId();
            FillCombo();
            /***********/
          
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                StageOptions.Enabled = true;
                EmployeePost.Enabled = false;
                EmployeePost.Text = "Stagiaire";
            }
            else
            {
                StageOptions.Enabled = false;
                EmployeePost.Enabled = true;
                EmployeePost.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image jpeg (*.jpeg;*.jpg)|*.jpeg;*.jpg|Image gif(*.gif)|*.gif|Image png (*.png)|*.png|Image Bitmap (*.bmp)|*.bmp";
            if (of.ShowDialog() == DialogResult.OK)
            {
                ImagePath.Text = of.FileName;             
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Etes-vous sûr de vouloir renvoyer cet employé ?","Confirmer le renvoi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand("DELETE FROM " + TableName + "EmployeeTable WHERE Id = @ID", con);
                cmd.Parameters.Add(new SqlParameter("@ID", EmployeeId.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Employé renvoyé avec succès");
                }

                Actualiser();               
                con.Close();
                TakeMaxId();
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string sexe;            

            try
            {
                con.Open();

                int id = int.Parse(max.Text);
                id += 1;
                if (Masculin.Checked)
                {
                    sexe = "M";
                }
                else
                {
                    sexe = "F";
                }

                if (checkBox1.Checked)
                {
                    cmd = new SqlCommand("INSERT INTO " + TableName + "EmployeeTable (Id, Nom, Prenom, Sexe, Date, Poste, Contact, Image, Stagiaire , Fin, Salaire) VALUES (@ID ,@NOM ,@PRENOM ,'" + sexe + "',@DATE, @POSTE, @CONTACT, @IMAGE, 'OUI', @FIN, @SALAIRE)", con);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO " + TableName + "EmployeeTable (Id, Nom, Prenom, Sexe, Date, Poste, Contact, Image, Stagiaire, Salaire) VALUES (@ID ,@NOM ,@PRENOM ,'" + sexe + "',@DATE, @POSTE, @CONTACT, @IMAGE, 'NON',@SALAIRE)", con);
                }

                cmd.Parameters.Add(new SqlParameter("@ID", id));
                cmd.Parameters.Add(new SqlParameter("@NOM", EmployeeName.Text));
                cmd.Parameters.Add(new SqlParameter("@PRENOM", EmployeeSurName.Text));
                cmd.Parameters.Add(new SqlParameter("@DATE", EmployeeStartDate.Value));
                cmd.Parameters.Add(new SqlParameter("@POSTE", EmployeePost.Text));
                cmd.Parameters.Add(new SqlParameter("@CONTACT", EmployeeContact.Text));
                cmd.Parameters.Add(new SqlParameter("@FIN", EmployeeEndOfStage.Value));
                cmd.Parameters.Add(new SqlParameter("@SALAIRE", EmployeeStageSalary.Text));
                cmd.Parameters.Add(new SqlParameter("@IMAGE", ImagePath.Text));
                
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Employé ajouter avec succès");
                }
                Actualiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            con.Close();
            TakeMaxId();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sexe;            
            try
            {

                con.Open();

                if (Masculin.Checked)
                {
                    sexe = "M";
                }
                else
                {
                    sexe = "F";
                }

                if (checkBox1.Checked)
                {
                    cmd = new SqlCommand("UPDATE " + TableName + "EmployeeTable SET Nom= @NOM, Prenom= @PRENOM, Date= @DATE, Poste = @POSTE, Contact= @CONTACT, Fin = @FIN, Salaire = @SALAIRE, Image= @IMAGE, Sexe = '" + sexe + "', Stagiaire = 'OUI' WHERE Id= @ID", con);
                }
                else
                {
                    cmd = new SqlCommand("UPDATE " + TableName + "EmployeeTable SET Nom= @NOM, Prenom= @PRENOM, Date= @DATE, Poste = @POSTE, Contact= @CONTACT, Image= @IMAGE, Sexe = '" + sexe + "', Stagiaire = 'NON', Salaire = @SALAIRE WHERE Id= @ID", con);
                }

                cmd.Parameters.Add(new SqlParameter("@ID", EmployeeId.Text));
                cmd.Parameters.Add(new SqlParameter("@NOM", EmployeeName.Text));
                cmd.Parameters.Add(new SqlParameter("@PRENOM", EmployeeSurName.Text));
                cmd.Parameters.Add(new SqlParameter("@DATE", EmployeeStartDate.Value));
                cmd.Parameters.Add(new SqlParameter("@POSTE", EmployeePost.Text));
                cmd.Parameters.Add(new SqlParameter("@CONTACT", EmployeeContact.Text));
                cmd.Parameters.Add(new SqlParameter("@FIN", EmployeeEndOfStage.Value));
                cmd.Parameters.Add(new SqlParameter("@SALAIRE", EmployeeStageSalary.Text));
                cmd.Parameters.Add(new SqlParameter("@IMAGE", ImagePath.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Employé Modifier avec succès");
                }
                Actualiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
            con.Close();
            TakeMaxId();
        }

        private void ImagePath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ImagePath.Text != null)
                {
                    ImageDeProfil.Image = Image.FromFile(ImagePath.Text);
                }
                else
                {
                    ImageDeProfil.Image = null;
                }
            }
            catch (Exception)
            {

            }
        }

        private void EmployeePost_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM " + TableName + "PostTable WHERE Nom = '" + EmployeePost.Text + "'", con);
            
            try
            {
                con.Open();
                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    int sSalary = DataReader.GetInt32(2);
                    EmployeeStageSalary.Text = sSalary.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (EmployeePost.Text == "Stagiaire")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Alfred-Remy KOUMNDA\Documents\liste des employés.xls";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            ListeDesEmployés.ExportToXls(path);

            MessageBox.Show("Fichier enregistrer au chemin : " + path);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VisualiseurCrystal vr = new VisualiseurCrystal();
            vr.TableName = UserProfil.Text;
            vr.EmployeeId = EmployeeId.Text;
            vr.Show();
        }

        private void reportGender_TextChanged(object sender, EventArgs e)
        {
            if (reportGender.Text == "F")
            {
                Feminin.Checked = true;
                Masculin.Checked = false;
            }
            else { Masculin.Checked = true; Feminin.Checked = false; }

        }

    }
}