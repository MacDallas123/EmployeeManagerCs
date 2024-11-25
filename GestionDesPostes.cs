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

namespace EngineeringProjet
{
    public partial class GestionDesPostes : DevExpress.XtraEditors.XtraForm
    {
        public GestionDesPostes()
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

        int PostNumber = 0;

        private void TakeMaxId()
        {
            cmd = new SqlCommand("SELECT * FROM " + TableName + "PostTable;", con);
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + TableName + "PostTable", con);
            sda.Fill(tbl);
            PostBindingSouce.DataSource = tbl;
            ListeDesPostes.DataSource = PostBindingSouce;

            PostNumber = PostBindingSouce.Count;
            PostNb.Text = PostNumber.ToString();

        }

        private void GestionDesPostes_Load(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("CREATE TABLE " + TableName + "PostTable ( Id INT NOT NULL, Nom NVARCHAR(50) NOT NULL, Salaire INT NOT NULL, Description TEXT NULL, CONSTRAINT PK_" + TableName + "PostTable PRIMARY KEY CLUSTERED (Id ASC))", con);
                int i = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                //Rien ne se passe...0213
            }

            try
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + TableName + "PostTable", con);
                sda.Fill(tbl);
                PostBindingSouce.DataSource = tbl;
                ListeDesPostes.DataSource = PostBindingSouce;
                layoutView1.Columns[0].Visible = false;

                PostId.DataBindings.Add("text", PostBindingSouce, "Id");
                PostName.DataBindings.Add("text", PostBindingSouce, "Nom");
                PostSalary.DataBindings.Add("text", PostBindingSouce, "Salaire");
                PostDescription.DataBindings.Add("text", PostBindingSouce, "Description");

                PostNumber = PostBindingSouce.Count;
                PostNb.Text = PostNumber.ToString();

                label10.Hide();
                max.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            TakeMaxId();
        }

        private void button4_Click(object sender, EventArgs e)
        {           

            try
            {
                con.Open();
                int id = int.Parse(max.Text);
                id += 1;

                cmd = new SqlCommand("INSERT INTO " + TableName + "PostTable (Id, Nom, Salaire, Description) VALUES (@ID ,@NOM ,@SALAIRE ,@DESCRIPTION)", con);

                cmd.Parameters.Add(new SqlParameter("@ID", id));
                cmd.Parameters.Add(new SqlParameter("@NOM", PostName.Text));
                cmd.Parameters.Add(new SqlParameter("@SALAIRE", PostSalary.Text));
                cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", PostDescription.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Poste ajouter avec succès");
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

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            try
            {

                cmd = new SqlCommand("UPDATE " + TableName + "PostTable SET Nom = @NOM, Salaire = @SALAIRE, Description = @DESCRIPTION WHERE Id= @ID", con);

                cmd.Parameters.Add(new SqlParameter("@ID", PostId.Text));
                cmd.Parameters.Add(new SqlParameter("@NOM", PostName.Text));
                cmd.Parameters.Add(new SqlParameter("@SALAIRE", PostSalary.Text));
                cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", PostDescription.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Poste Modifier avec succès");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TakeMaxId();
            con.Close();

            Actualiser();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce poste ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand("DELETE FROM " + TableName + "PostTable WHERE Id = @ID", con);
                cmd.Parameters.Add(new SqlParameter("@ID", PostId.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Poste supprimé avec succès");
                }
                Actualiser();

                TakeMaxId();

                con.Close();                
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog s_dialog = new SaveFileDialog();
            s_dialog.Filter = "Fichier Excel (*.xls )|*.xls";
            if (s_dialog.ShowDialog() == DialogResult.OK)
            {
                ListeDesPostes.ExportToXls(s_dialog.FileName);
            }
        }
    }
}