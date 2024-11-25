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
    public partial class GestionDesProduits : DevExpress.XtraEditors.XtraForm
    {
        public GestionDesProduits()
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

        int ProductionNumber = 0;

        private void TakeMaxId()
        {
            cmd = new SqlCommand("SELECT * FROM " + TableName + "ProductionTable;", con);
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + TableName + "ProductionTable", con);
            sda.Fill(tbl);
            ProductBindingSouce.DataSource = tbl;
            ListeDesProduits.DataSource = ProductBindingSouce;

            ProductionNumber = ProductBindingSouce.Count;
            ProductionNb.Text = ProductionNumber.ToString();
        }

        private void GestionDesProduits_Load(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmd = new SqlCommand("CREATE TABLE " + TableName + "ProductionTable ( Id INT NOT NULL, Nom NVARCHAR(50) NOT NULL, Cout INT NOT NULL, Description TEXT NULL, CONSTRAINT PK_" + TableName + "ProductionTable PRIMARY KEY CLUSTERED (Id ASC))", con);
                int i = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                //Rien ne se passe...0213
            }

            try
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + TableName + "ProductionTable", con);
                sda.Fill(tbl);
                ProductBindingSouce.DataSource = tbl;
                ListeDesProduits.DataSource = ProductBindingSouce;
                layoutView1.Columns[0].Visible = false;

                ProductionId.DataBindings.Add("text", ProductBindingSouce, "Id");
                ProductionName.DataBindings.Add("text", ProductBindingSouce, "Nom");
                ProductionCost.DataBindings.Add("text", ProductBindingSouce, "Cout");
                ProductionDescription.DataBindings.Add("text", ProductBindingSouce, "Description");

                ProductionNumber = ProductBindingSouce.Count;
                ProductionNb.Text = ProductionNumber.ToString();

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
            con.Open();

            try
            {
                int id = int.Parse(max.Text);
                id += 1;

                cmd = new SqlCommand("INSERT INTO " + TableName + "ProductionTable (Id, Nom, Cout, Description) VALUES (@ID ,@NOM ,@COUT ,@DESCRIPTION)", con);

                cmd.Parameters.Add(new SqlParameter("@ID", id));
                cmd.Parameters.Add(new SqlParameter("@NOM", ProductionName.Text));
                cmd.Parameters.Add(new SqlParameter("@COUT", ProductionCost.Text));
                cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", ProductionDescription.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("produit ajouter avec succès");
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

                cmd = new SqlCommand("UPDATE " + TableName + "ProductionTable SET Nom = @NOM, Cout = @COUT, Description = @DESCRIPTION WHERE Id= @ID", con);
                cmd.Parameters.Add(new SqlParameter("@ID", ProductionId.Text));
                cmd.Parameters.Add(new SqlParameter("@NOM", ProductionName.Text));
                cmd.Parameters.Add(new SqlParameter("@COUT", ProductionCost.Text));
                cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", ProductionDescription.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Produit Modifier avec succès");
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
            DialogResult dr = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce produit ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand("DELETE FROM " + TableName + "ProductionTable WHERE Id = @ID", con);
                cmd.Parameters.Add(new SqlParameter("@ID", ProductionId.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("produit supprimé avec succès");
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
                ListeDesProduits.ExportToXls(s_dialog.FileName);
            }

        }
    }
}