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
    public partial class GestionDesGains : DevExpress.XtraEditors.XtraForm
    {
        public GestionDesGains()
        {
            InitializeComponent();
            FillCombo();
        }

        public string TableName
        {
            get { return UserProfil.Text; }
            set { UserProfil.Text = value; }
        }

        public string Capital
        {
            get { return TotalGain.Text; }
            set { TotalGain.Text = value; }
        }


        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Alfred-Remy KOUMNDA\Documents\Visual Studio 2013\Projects\EnterpriseManagement\EngineeringProjet\ManagementProject.mdf';Integrated Security=True;Connect Timeout=30");
        //Data Source=.\SQLEXPRESS;Initial Catalog=EmDatabase;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=EmDatabase;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader DataReader;

        int ReturnNumber = 0;
        decimal somme = 0;

        private void FillCombo()
        {
            cmd = new SqlCommand("SELECT * FROM " + TableName + "ProductionTable;", con);
            try
            {
                con.Open();
                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    string sName = DataReader.GetString(1);
                    ProductList.Items.Add(sName);
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
            cmd = new SqlCommand("SELECT * FROM " + TableName + "ReturnTable;", con);
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

        public void UpdateGainValue()
        {
            cmd = new SqlCommand("SELECT * FROM " + TableName + "ReturnTable;", con);           
            try
            {
                int somme = 0;
                con.Open();
                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    int sGain = DataReader.GetInt32(2);
                    somme += sGain;
                    TotalGain.Text = somme.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        public void Actualiser()
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + TableName + "ReturnTable", con);
            sda.Fill(tbl);
            GainBindingSouce.DataSource = tbl;
            ListeDesRecettes.DataSource = GainBindingSouce;

            ReturnNumber = GainBindingSouce.Count;
            ReturnNb.Text = ReturnNumber.ToString();
        }

        private void GestionDesGains_Load(object sender, EventArgs e)
        {
            UpdateGainValue();
            FillCombo();
            TakeMaxId();

            con.Open();
            try
            {       
                cmd = new SqlCommand("CREATE TABLE " + TableName + "ReturnTable ( Id INT NOT NULL, Jour DATETIME NOT NULL, Revenu INT NOT NULL, CONSTRAINT PK_" + TableName + "ReturnTable PRIMARY KEY CLUSTERED (Id ASC))", con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                //Rien ne se passe...
            }

            try
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + TableName + "ReturnTable", con);
                sda.Fill(tbl);
                GainBindingSouce.DataSource = tbl;
                ListeDesRecettes.DataSource = GainBindingSouce;
                layoutView1.Columns[0].Visible = false;

                ReturnId.DataBindings.Add("text", GainBindingSouce, "Id");
                ReturnsDay.DataBindings.Add("text", GainBindingSouce, "Jour");
                TotalReturn.DataBindings.Add("text", GainBindingSouce, "Revenu");

                ReturnNumber = GainBindingSouce.Count;
                ReturnNb.Text = ReturnNumber.ToString();

                label10.Hide();
                max.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            con.Close();
          

        }

        private void ReturnAdd_Click(object sender, EventArgs e)
        {
            UpdateGainValue();           

            try
            {
                con.Open();
                int id = int.Parse(max.Text);
                id += 1;

                cmd = new SqlCommand("INSERT INTO " + TableName + "ReturnTable (Id, Jour, Revenu) VALUES (@ID ,@JOUR ,@REVENU)", con);

                cmd.Parameters.Add(new SqlParameter("@ID", id));
                cmd.Parameters.Add(new SqlParameter("@JOUR", ReturnsDay.Value));
                cmd.Parameters.Add(new SqlParameter("@REVENU", TotalReturn.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Recette ajouter avec succès");
                }

                Actualiser();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TakeMaxId();
            con.Close();

            somme = 0;
            TotalReturn.Text = "0";            

        }

        private void ReturnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Etes-vous sûr de vouloir supprimer cette recette ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand("DELETE FROM " + TableName + "ReturnTable WHERE Id = @ID", con);
                cmd.Parameters.Add(new SqlParameter("@ID", ReturnId.Text));

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Recette supprimé avec succès");
                }
                Actualiser();

                TakeMaxId();
                con.Close();               
            }

        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM " + TableName + "ProductionTable WHERE Nom = '" + ProductList.Text + "'", con);

            try
            {
                con.Open();
                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    int sSalary = DataReader.GetInt32(2);
                    ProductUnitedPrice.Text = sSalary.ToString();                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            TakeMaxId();
        }

        private void Add_Click(object sender, EventArgs e)
        {           
            int Prix = int.Parse(ProductUnitedPrice.Text);
            decimal Quantite = Quantity.Value;
            int Autres = int.Parse(OthersReturns.Text);

            somme += (Prix * Quantite) + Autres;
            TotalReturn.Text = somme.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            somme = 0;
            TotalReturn.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Alfred-Remy KOUMNDA\Documents\liste des recettes.xls";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            ListeDesRecettes.ExportToXls(path);

            MessageBox.Show("Fichier enregistrer au chemin : " + path);
        }
    }
}