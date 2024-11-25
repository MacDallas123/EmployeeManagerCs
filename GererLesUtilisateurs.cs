using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EngineeringProjet
{
    public partial class GererLesUtilisateurs : DevExpress.XtraEditors.XtraForm
    {
        public GererLesUtilisateurs()
        {
            InitializeComponent();
        }

        public string NomDuProfil
        {
            get
            {
                return UserText.Text;
            }
            set
            {
                UserText.Text = value;
            }
        }

        public string EnterpriseName
        {
            get
            {
                return CompagnieText.Text;
            }
            set
            {
                CompagnieText.Text = value;
            }
        }

        public string Description
        {
            get
            {
                return DescriptionText.Text;
            }
            set
            {
                DescriptionText.Text = value;
            }
        }




        private readonly SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=EmDatabase;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private SqlCommand cmd;
        private SqlDataReader DataReader;
        private int ProfilNumber = 0;

        private void TakeMaxId()
        {
            cmd = new SqlCommand("SELECT * FROM DbProfil ORDER BY id;", con);
            try
            {
                con.Open();
                DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    var sId = DataReader.GetInt32(0);
                    max.Text = sId.ToString();
                }
            }
            catch (Exception)
            {
            }
            con.Close();
        }

        private void Actualiser()
        {
            dbProfilTableAdapter.Fill(profilDataSet.DbProfil);
            ListeDeProfils.DataSource = dbProfilBindingSource;

            ProfilNumber = dbProfilBindingSource.Count;
            ProfilsNb.Text = ProfilNumber.ToString();
        }

        private void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void GererLesUtilisateurs_Load(object sender, EventArgs e)
        {
            Actualiser();
            PassWordText.Focus();
            IdText.DataBindings.Add("text", dbProfilBindingSource, "Id");

            label12.Hide();
            max.Hide();

            TakeMaxId();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dbProfilBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dbProfilBindingSource.MoveNext();
        }

        private void AddProfilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(max.Text);
                id += 1;

                OpenConnection();
                if (PassWordText.Text == ConfirmPassText.Text)
                {
                    var cmd = new SqlCommand("INSERT INTO DbProfil (Id, Utilisateur, Compagnie, MotDePasse, Description) VALUES (@ID ,@USER ,@COMPANY ,@PASSWORD ,@DESCRIPTION)", con);

                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@USER", UserText.Text));
                    cmd.Parameters.Add(new SqlParameter("@COMPANY", CompagnieText.Text));
                    cmd.Parameters.Add(new SqlParameter("@PASSWORD", PassWordText.Text));
                    cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", DescriptionText.Text));

                    var i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Profil ajouter avec succès");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez réessayer de saisir le mot de passe !");
                    PassWordText.Text = string.Empty;
                    ConfirmPassText.Text = string.Empty;
                }

                Actualiser();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Echec de l'opération");
            }

            TakeMaxId();
            CloseConnection();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            IdText.Text = string.Empty;
            UserText.Text = string.Empty;
            CompagnieText.Text = string.Empty;
            PassWordText.Text = string.Empty;
            ConfirmPassText.Text = string.Empty;
            LastPassWordText.Text = string.Empty;
            DescriptionText.Text = string.Empty;
        }

        private void EditProfilBtn_Click(object sender, EventArgs e)
        {
            OpenConnection();
            if (LastPassWordText.Text == ConfirmPassText.Text)
            {
                var cmd = new SqlCommand("UPDATE DbProfil SET Utilisateur= @USER, Compagnie= @COMPANY, MotDePasse = @PASSWORD, Description= @DESCRIPTION WHERE Id= @ID", con);

                cmd.Parameters.Add(new SqlParameter("@ID", IdText.Text));
                cmd.Parameters.Add(new SqlParameter("@USER", UserText.Text));
                cmd.Parameters.Add(new SqlParameter("@COMPANY", CompagnieText.Text));
                cmd.Parameters.Add(new SqlParameter("@PASSWORD", PassWordText.Text));
                cmd.Parameters.Add(new SqlParameter("@DESCRIPTION", DescriptionText.Text));

                var i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Profil Modifier avec succès");
                }
                Actualiser();
            }
            else
            {
                MessageBox.Show("Echec de la modification du mot de passe : Veuillez saisir le nouveau mot de passe avant de confirmer l'ancien mot de passe pour modifier celui-ci.");
                PassWordText.Text = string.Empty;
                ConfirmPassText.BackColor = Color.Red;
            }
            TakeMaxId();
            CloseConnection();
        }

        private void DeleteProfilBtn_Click(object sender, EventArgs e)
        {
            OpenConnection();
            if (LastPassWordText.Text == PassWordText.Text && PassWordText.Text == ConfirmPassText.Text)
            {
                var cmd = new SqlCommand("DELETE FROM DbProfil WHERE Id = @ID", con);
                cmd.Parameters.Add(new SqlParameter("@ID", IdText.Text));

                var cmd1 = new SqlCommand("IF EXISTS (SELECT * FROM  " + UserText.Text + "EmployeeTable) ROLLBACK TRANSACTION DROP TABLE " + UserText.Text + "EmployeeTable;", con);
                var cmd2 = new SqlCommand("IF EXISTS (SELECT * FROM  " + UserText.Text + "AdministratorTable) ROLLBACK TRANSACTION DROP TABLE " + UserText.Text + "AdministratorTable;", con);
                var cmd3 = new SqlCommand("IF EXISTS (SELECT * FROM  " + UserText.Text + "PostTable) ROLLBACK TRANSACTION DROP TABLE " + UserText.Text + "PostTable;", con);
                var cmd4 = new SqlCommand("IF EXISTS (SELECT * FROM  " + UserText.Text + "ProductionTable) ROLLBACK TRANSACTION DROP TABLE " + UserText.Text + "ProductionTable;", con);
                var cmd5 = new SqlCommand("IF EXISTS (SELECT * FROM  " + UserText.Text + "ReturnTable) ROLLBACK TRANSACTION DROP TABLE " + UserText.Text + "ReturnTable;", con);

                try
                {
                    if (MessageBox.Show("Etes vous sûr de vouloir supprimer ce profil, ceci effacera la totalité de vos données jointes à ce profil ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            cmd1.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            cmd3.ExecuteNonQuery();
                            cmd4.ExecuteNonQuery();
                            cmd5.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                        }

                        var i = cmd.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("Profil Supprimer avec succès");
                        }
                        dbProfilBindingSource.RemoveCurrent();
                    }
                    Actualiser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                TakeMaxId();
            }
            else
            {
                MessageBox.Show("Echec de la saisie de l'ancien mot de passe ou de la confirmation de celui-ci");
                PassWordText.Text = string.Empty;
                ConfirmPassText.Text = string.Empty;
                ConfirmPassText.BackColor = Color.Red;
                ConfirmPassText.BackColor = Color.Red;
            }
            CloseConnection();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                LastPassWordText.UseSystemPasswordChar = false;
                PassWordText.UseSystemPasswordChar = false;
            }
            else
            {
                LastPassWordText.UseSystemPasswordChar = true;
                PassWordText.UseSystemPasswordChar = true;
            }
        }

        private void UseProfilBtn_Click(object sender, EventArgs e)
        {
        }

        private void UseProfilBtn_MouseHover(object sender, EventArgs e)
        {
            if (PassWordText.Text == LastPassWordText.Text)
            {
                UseProfilBtn.DialogResult = DialogResult.OK;
            }
            else
            {
                UseProfilBtn.DialogResult = DialogResult.None;
                MessageBox.Show("Veuillez saisir le mot de passe correct pour utiliser le profil !", "Information manquante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IdText_TextChanged(object sender, EventArgs e)
        {
            PassWordText.Text = string.Empty;
            ConfirmPassText.Text = string.Empty;
        }
    }
}
