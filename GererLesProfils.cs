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
using EngineeringProjet.ProfilsTableAdapters;

namespace EngineeringProjet
{
    public partial class ModifierProfil : DevExpress.XtraEditors.XtraForm
    {
        public ModifierProfil()
        {
            InitializeComponent();
        }

        public BindingSource commonSource
        {
            get
            {
                Profils ds = new Profils();
                new AddProfilTableAdapter().Fill(ds.AddProfil);
                bindingSource1.DataSource = new AddProfilTableAdapter().GetData();
                return bindingSource1;
            }

            set
            {
                bindingSource1 = value;
            }
        }

        public void Refreshing()
        {
                Profils ds = new Profils();
                new AddProfilTableAdapter().Fill(ds.AddProfil);
                bindingSource1.DataSource = new AddProfilTableAdapter().GetData();
        }


        private void ModifierProfil_Load(object sender, EventArgs e)
        {
            Refreshing();
            NomDuProfil.DataBindings.Add("text", bindingSource1, "Utilisateur");
            NomDeLaCompagnie.DataBindings.Add("text", bindingSource1, "Compagnie");
            Description.DataBindings.Add("text", bindingSource1, "Description");
            MotDePasse.DataBindings.Add("text", bindingSource1, "Mot de passe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddProfilTableAdapter at = new AddProfilTableAdapter();
            try
            {
                int id = Convert.ToInt32(IdText.Text);
                if (MotDePasse.Text == ConfirmerMP.Text)
                {
                    at.Insert(id, NomDuProfil.Text, NomDeLaCompagnie.Text, MotDePasse.Text, Description.Text);
                    this.Refreshing();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*NomDuProfil.Text = "";
            NomDeLaCompagnie.Text = "";
            MotDePasse.Text = "";
            ConfirmerMP.Text = "";
            Description.Text = "";*/
        }
    }
}