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
    public partial class GestionDeLAdministration : DevExpress.XtraEditors.XtraForm
    {
        public GestionDeLAdministration()
        {
            InitializeComponent();
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
        int AdministratorNumber = 0;

        private void TakeMaxId()
        {
            cmd = new SqlCommand("SELECT * FROM " + TableName + "AdministratorTable ORDER BY id;", con);
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + TableName + "AdministratorTable ORDER BY nom", con);
            sda.Fill(tbl);
            AdministratorBindingSource.DataSource = tbl;
            ListeDesAdministrateurs.DataSource = AdministratorBindingSource;

            AdministratorNumber = AdministratorBindingSource.Count;
            AdministratorNb.Text = AdministratorNumber.ToString();
        }


        private void GestionDeLAdministration_Load(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("CREATE TABLE " + TableName + "AdministratorTable ( Id INT NOT NULL, Nom NVARCHAR(50) NOT NULL, Prenom NVARCHAR(50) NOT NULL, Sexe NVARCHAR(10) NOT NULL, Poste NVARCHAR(50) NOT NULL, Salaire INT NULL, Contact NVARCHAR(50) NOT NULL, Image TEXT NULL, CONSTRAINT PK_" + TableName + "AdministratorTable PRIMARY KEY CLUSTERED (Id ASC))", con);
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Création de la liste des administrateurs : " + TableName + "AdministratorTable du nouveau profil créée");
                }

            }
            catch (Exception)
            {
                //Rien ne se passe...0213
            }

            try
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + TableName + "AdministratorTable ORDER BY nom", con);
                sda.Fill(tbl);
                AdministratorBindingSource.DataSource = tbl;
                ListeDesAdministrateurs.DataSource = AdministratorBindingSource;
                gridBand1.Columns[0].Visible = false;

                AdministratorId.DataBindings.Add("text", AdministratorBindingSource, "Id");
                AdministratorName.DataBindings.Add("text", AdministratorBindingSource, "Nom");
                AdministratorSurName.DataBindings.Add("text", AdministratorBindingSource, "Prenom");
                AdministratorPost.DataBindings.Add("text", AdministratorBindingSource, "Poste");
                AdministratorSalary.DataBindings.Add("text", AdministratorBindingSource, "Salaire");
                AdministratorContact.DataBindings.Add("text", AdministratorBindingSource, "Contact");
                ImagePath.DataBindings.Add("text", AdministratorBindingSource, "Image");
                reportGender.DataBindings.Add("text", AdministratorBindingSource, "Sexe");

                AdministratorNumber = AdministratorBindingSource.Count;
                AdministratorNb.Text = AdministratorNumber.ToString();

                ImagePath.Hide();
                label8.Hide();
                max.Hide();
                reportGender.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            TakeMaxId();
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

                cmd = new SqlCommand("INSERT INTO " + TableName + "AdministratorTable (Id, Nom, Prenom, Sexe, Poste, Salaire, Contact, Image) VALUES (@ID ,@NOM ,@PRENOM ,'" + sexe + "', @POSTE, @SALAIRE, @CONTACT, @IMAGE)", con);


                cmd.Parameters.Add(new SqlParameter("@ID", id));
                cmd.Parameters.Add(new SqlParameter("@NOM", AdministratorName.Text));
                cmd.Parameters.Add(new SqlParameter("@PRENOM", AdministratorSurName.Text));
                cmd.Parameters.Add(new SqlParameter("@POSTE", AdministratorPost.Text));
                cmd.Parameters.Add(new SqlParameter("@SALAIRE", AdministratorSalary.Text));
                cmd.Parameters.Add(new SqlParameter("@CONTACT", AdministratorContact.Text));
                cmd.Parameters.Add(new SqlParameter("@IMAGE", ImagePath.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Administrateur ajouter avec succès");
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

                cmd = new SqlCommand("UPDATE " + TableName + "AdministratorTable SET Nom= @NOM, Prenom= @PRENOM, Poste = @POSTE, Salaire = @SALAIRE, Contact = @CONTACT, Image = @IMAGE, Sexe = '" + sexe + "' WHERE Id= @ID", con);

                cmd.Parameters.Add(new SqlParameter("@ID", AdministratorId.Text));
                cmd.Parameters.Add(new SqlParameter("@NOM", AdministratorName.Text));
                cmd.Parameters.Add(new SqlParameter("@PRENOM", AdministratorSurName.Text));
                cmd.Parameters.Add(new SqlParameter("@POSTE", AdministratorPost.Text));
                cmd.Parameters.Add(new SqlParameter("@SALAIRE", AdministratorSalary.Text));
                cmd.Parameters.Add(new SqlParameter("@CONTACT", AdministratorContact.Text));
                cmd.Parameters.Add(new SqlParameter("@IMAGE", ImagePath.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Administrateur Modifier avec succès");
                }
                Actualiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TakeMaxId();
            con.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Etes-vous sûr de vouloir retirer cet administrateur ?", "Confirmer le retrait", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand("DELETE FROM " + TableName + "AdministratorTable WHERE Id = @ID", con);
                cmd.Parameters.Add(new SqlParameter("@ID", AdministratorId.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Administrateur retirer avec succès");
                }

                Actualiser();
                TakeMaxId();
                con.Close();
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Alfred-Remy KOUMNDA\Documents\liste des administrateurs.xls";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            ListeDesAdministrateurs.ExportToXls(path);

            MessageBox.Show("Fichier enregistrer au chemin : " + path);

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