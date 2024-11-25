using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;

namespace EngineeringProjet
{
    public partial class VisualiseurCrystal : DevExpress.XtraEditors.XtraForm
    {
        public VisualiseurCrystal()
        {
            InitializeComponent();
        }

        public String TableName
        {
            get { return heading.Text; }
            set { heading.Text = value; }
        }

        public String EmployeeId
        {
            get { return Id.Text; }
            set { Id.Text = value; }
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=EmDatabase;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void VisualiseurCristal_Load(object sender, EventArgs e)
        {
            Id.Hide();
            MyReport mr = new MyReport();

            try
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM " + TableName + "EmployeeTable WHERE Id = " + Id.Text + ";", con);
                sda.Fill(tbl);

                mr.SetDataSource(tbl);
                crystalReportViewer1.ReportSource = mr;
                crystalReportViewer1.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["EngineeringProjet.Properties.Settings.ManagementConnectionString"].ToString();

                String sql = "SELECT * FROM MyReportView";

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            
                sda.Fill(ds, "MyReportView");
                DataTable dt = ds.Tables["MyReportView"];

                mr.SetDataSource(dt);
                crystalReportViewer1.ReportSource = mr;
                crystalReportViewer1.Refresh();*/

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}