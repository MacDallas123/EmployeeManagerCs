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
    public partial class GestionDesDépenses : DevExpress.XtraEditors.XtraForm
    {
        public GestionDesDépenses()
        {
            InitializeComponent();
        }

        public string TableName
        {
            get { return UserProfil.Text; }
            set { UserProfil.Text = value; }
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Alfred-Remy KOUMNDA\Documents\Visual Studio 2013\Projects\EnterpriseManagement\EngineeringProjet\ManagementProject.mdf';Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataReader DataReader;

        GestionDesGains gg = new GestionDesGains();

        public void PayeEmployee()
        {
            cmd = new SqlCommand("SELECT * FROM " + TableName + "EmployeeTable", con);
            int Somme = 0;

            try
            {
                con.Open();
                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {                   
                    int Salaire = DataReader.GetInt32(11);
                    Somme += Salaire;
                    SpendingEmployee.Text = Somme.ToString();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        public void PayeAdministrator()
        {
            cmd = new SqlCommand("SELECT * FROM " + TableName + "AdministratorTable", con);
            int Somme = 0;

            try
            {
                con.Open();
                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {               
                    int Salaire = DataReader.GetInt32(5);
                    Somme += Salaire;
                    SpendingAdministrator.Text = Somme.ToString();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    possession.Text = somme.ToString();
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

        private void GestionDesDépenses_Load(object sender, EventArgs e)
        {
            PayeEmployee();
            PayeAdministrator();

            UpdateGainValue();

            int globalCapital = int.Parse(possession.Text);
            int minimum = globalCapital / 2;
            BaseValue.Text = minimum.ToString();

            try
            {
                int EmployeeSpendind = int.Parse(SpendingEmployee.Text);
                int AdministratorSpendind = int.Parse(SpendingAdministrator.Text);
                int MaterialSpendind = int.Parse(SpendingMaterial.Text);

                TotalSpending.Text = (EmployeeSpendind + AdministratorSpendind + MaterialSpendind).ToString();

                int Capital = int.Parse(possession.Text);
                int SpendingValue = int.Parse(TotalSpending.Text);

                Rest.Text = (Capital - SpendingValue).ToString();

                if (Capital - SpendingValue <= 0)
                {
                    Rest.BackColor = Color.Red;
                    Notice.BackColor = Color.Red;
                    Notice.ForeColor = Color.White;
                    Notice.Text = "Capital Restant en mauvais état : veuillez à combler ce manque afin de ne pas réaliser de pertes.";
                }
                else if (Capital - SpendingValue < minimum)
                {
                    Rest.BackColor = Color.Yellow;
                    Notice.BackColor = Color.Yellow;
                    Notice.ForeColor = Color.Black;
                    Notice.Text = "Attention capital restant faible: La somme restante est très basse et serait susceptible de ne pas couvrir d'autres dépenses.";
                }
                else
                {
                    Rest.BackColor = Color.LightGreen;
                    Notice.BackColor = Color.Green;
                    Notice.Text = "Le Capital restant de l'entreprise en bon etat, les dépenses couvrent moins de la moitier du capital.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            PayeEmployee();
            PayeAdministrator();

            int minimum = int.Parse(BaseValue.Text);

            try
            {
                int EmployeeSpendind = int.Parse(SpendingEmployee.Text);
                int AdministratorSpendind = int.Parse(SpendingAdministrator.Text);
                int MaterialSpendind = int.Parse(SpendingMaterial.Text);

                TotalSpending.Text = (EmployeeSpendind + AdministratorSpendind + MaterialSpendind).ToString();

                int Capital = int.Parse(possession.Text);
                int SpendingValue = int.Parse(TotalSpending.Text);

                Rest.Text = (Capital - SpendingValue).ToString();

                if (Capital - SpendingValue <= 0)
                {
                    Rest.BackColor = Color.Red;
                    Notice.BackColor = Color.Red;
                    Notice.ForeColor = Color.White;
                    Notice.Text = "Capital Restant en mauvais état : veuillez à combler ce manque afin de ne pas réaliser de pertes.";
                }
                else if (Capital - SpendingValue < minimum)
                {
                    Rest.BackColor = Color.Yellow;
                    Notice.BackColor = Color.Yellow;
                    Notice.ForeColor = Color.Black;
                    Notice.Text = "Attention capital restant faible: La somme restante est très basse et serait susceptible de ne pas couvrir d'autres dépenses.";
                }
                else
                {
                    Rest.BackColor = Color.LightGreen;
                    Notice.BackColor = Color.Green;
                    Notice.Text = "Le Capital restant de l'entreprise en bon etat, les dépenses couvrent moins de la moitier du capital.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sumPossession = int.Parse(possession.Text);
            int AddSumPoss = int.Parse(AddPossession.Text);

            sumPossession += AddSumPoss;

            possession.Text = sumPossession.ToString();
        }
    }
}