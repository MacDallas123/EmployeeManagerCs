using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace EngineeringProjet
{
    public partial class ManagementForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        public string User
        {
            get { return NameProfil.Text; }
            set { NameProfil.Text = value; }
        }

        public string Company
        {
            get { return Enterprise.Text; }
            set { Enterprise.Text = value; }
        }

        public string DescriptionText
        {
            get { return Description.Text; }
            set { Description.Text = value; }
        }



        private void ManagementForm_Load(object sender, EventArgs e)
        {
            GererLesUtilisateurs gu = new GererLesUtilisateurs();
            if (gu.ShowDialog() == DialogResult.OK)
            {
                User = gu.NomDuProfil;
                Company = gu.EnterpriseName;
                DescriptionText = gu.Description;
            }
            else
            {
                this.Close();
            }

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous vraiment quitter 'Management Pro' ?", "Confirmer", MessageBoxButtons.YesNo);
            if (reponse == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form ChildForm in MdiChildren)
            {
                ChildForm.Close();
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous vraiment quitter 'Management Pro' ?", "Confirmer", MessageBoxButtons.YesNo);
            if (reponse == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GererLesUtilisateurs gu = new GererLesUtilisateurs();
            if (gu.ShowDialog() == DialogResult.OK)
            {
                User = gu.NomDuProfil;
                Company = gu.EnterpriseName;
                DescriptionText = gu.Description;

                foreach (Form ChildForm in MdiChildren)
                {
                    ChildForm.Close();
                }
            }
            Refresh();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GestionDesEmployes ge = new GestionDesEmployes();
            try
            {
               foreach (GestionDesEmployes ge2 in MdiChildren)
                {
                    ge2.Close();
                }
            }
            catch (Exception)
            {
              
            }
            ge.TableName = User;

            ge.MdiParent = this;
            ge.Show();
        }

        private void Enterprise_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GestionDesPostes gp = new GestionDesPostes();
            try
            {
                foreach (GestionDesPostes ge2 in MdiChildren)
                {
                    ge2.Close();
                }
            }
            catch (Exception)
            {

            }

            gp.TableName = User;

            gp.MdiParent = this;
            gp.Show();

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GestionDeLAdministration ga = new GestionDeLAdministration();
            try
            {
                foreach (GestionDeLAdministration ge2 in MdiChildren)
                {
                    ge2.Close();
                }
            }
            catch (Exception)
            {

            }

            ga.TableName = User;

            ga.MdiParent = this;
            ga.Show();


        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GestionDesProduits gp = new GestionDesProduits();
            
            try
            {
                foreach (GestionDesProduits ge2 in MdiChildren)
                {
                    ge2.Close();
                }
            }
            catch (Exception)
            {

            }

            gp.TableName = User;

            gp.MdiParent = this;
            gp.Show();

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AproposDeManagementPro about = new AproposDeManagementPro();
            about.ShowDialog();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GestionDesDépenses gd = new GestionDesDépenses();

            gd.TableName = User;
            gd.ShowDialog();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GestionDesGains gg = new GestionDesGains();
            try
            {
                foreach (GestionDesGains ge2 in MdiChildren)
                {
                    ge2.Close();
                }
            }
            catch (Exception)
            {

            }

            gg.TableName = User;

            gg.MdiParent = this;
            gg.Show();


        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start(@"C:\Users\Alfred-Remy KOUMNDA\Documents\Visual Studio 2013\Projects\EnterpriseManagement\EngineeringProjet\Help.html");
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

    }
}
