namespace EngineeringProjet
{
    partial class GestionDeLAdministration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ImagePath = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.UserProfil = new System.Windows.Forms.Label();
            this.AdministratorId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.AdministratorSalary = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.AdministratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdministratorContact = new System.Windows.Forms.TextBox();
            this.Feminin = new System.Windows.Forms.RadioButton();
            this.Masculin = new System.Windows.Forms.RadioButton();
            this.AdministratorSurName = new System.Windows.Forms.TextBox();
            this.AdministratorName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageDeProfil = new System.Windows.Forms.PictureBox();
            this.AdministratorPost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.ListeDesAdministrateurs = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button5 = new System.Windows.Forms.Button();
            this.AdministratorNb = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.reportGender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdministratorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDeProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesAdministrateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePath
            // 
            this.ImagePath.AutoSize = true;
            this.ImagePath.Font = new System.Drawing.Font("SimSun", 3F);
            this.ImagePath.Location = new System.Drawing.Point(10, 245);
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.Size = new System.Drawing.Size(37, 4);
            this.ImagePath.TabIndex = 57;
            this.ImagePath.Text = "Chemin de l\'image";
            this.ImagePath.TextChanged += new System.EventHandler(this.ImagePath_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::EngineeringProjet.Properties.Resources.Modify;
            this.button2.Location = new System.Drawing.Point(325, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 39);
            this.button2.TabIndex = 56;
            this.button2.Text = "Modifier";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserProfil
            // 
            this.UserProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserProfil.AutoSize = true;
            this.UserProfil.Font = new System.Drawing.Font("Tahoma", 11F);
            this.UserProfil.Location = new System.Drawing.Point(11, 454);
            this.UserProfil.Name = "UserProfil";
            this.UserProfil.Size = new System.Drawing.Size(105, 18);
            this.UserProfil.TabIndex = 55;
            this.UserProfil.Text = "Choisir un profil";
            // 
            // AdministratorId
            // 
            this.AdministratorId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdministratorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdministratorId.Enabled = false;
            this.AdministratorId.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.AdministratorId.Location = new System.Drawing.Point(323, 117);
            this.AdministratorId.Name = "AdministratorId";
            this.AdministratorId.Size = new System.Drawing.Size(156, 23);
            this.AdministratorId.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(204, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 18);
            this.label13.TabIndex = 53;
            this.label13.Text = "N° :";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::EngineeringProjet.Properties.Resources.Create;
            this.button4.Location = new System.Drawing.Point(208, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 39);
            this.button4.TabIndex = 52;
            this.button4.Text = "&Ajouter";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdministratorSalary
            // 
            this.AdministratorSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdministratorSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdministratorSalary.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.AdministratorSalary.Location = new System.Drawing.Point(325, 330);
            this.AdministratorSalary.Name = "AdministratorSalary";
            this.AdministratorSalary.Size = new System.Drawing.Size(392, 23);
            this.AdministratorSalary.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::EngineeringProjet.Properties.Resources.Delete;
            this.button3.Location = new System.Drawing.Point(442, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 39);
            this.button3.TabIndex = 51;
            this.button3.Text = "Retirer";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(206, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Salaire :";
            // 
            // AdministratorContact
            // 
            this.AdministratorContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdministratorContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdministratorContact.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.AdministratorContact.Location = new System.Drawing.Point(325, 373);
            this.AdministratorContact.Name = "AdministratorContact";
            this.AdministratorContact.Size = new System.Drawing.Size(392, 23);
            this.AdministratorContact.TabIndex = 48;
            // 
            // Feminin
            // 
            this.Feminin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Feminin.AutoSize = true;
            this.Feminin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Feminin.Location = new System.Drawing.Point(657, 249);
            this.Feminin.Name = "Feminin";
            this.Feminin.Size = new System.Drawing.Size(60, 17);
            this.Feminin.TabIndex = 46;
            this.Feminin.Text = "Feminin";
            this.Feminin.UseVisualStyleBackColor = true;
            // 
            // Masculin
            // 
            this.Masculin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Masculin.AutoSize = true;
            this.Masculin.Checked = true;
            this.Masculin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Masculin.Location = new System.Drawing.Point(325, 248);
            this.Masculin.Name = "Masculin";
            this.Masculin.Size = new System.Drawing.Size(64, 17);
            this.Masculin.TabIndex = 45;
            this.Masculin.TabStop = true;
            this.Masculin.Text = "Masculin";
            this.Masculin.UseVisualStyleBackColor = true;
            // 
            // AdministratorSurName
            // 
            this.AdministratorSurName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdministratorSurName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdministratorSurName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.AdministratorSurName.Location = new System.Drawing.Point(325, 205);
            this.AdministratorSurName.Name = "AdministratorSurName";
            this.AdministratorSurName.Size = new System.Drawing.Size(392, 23);
            this.AdministratorSurName.TabIndex = 44;
            // 
            // AdministratorName
            // 
            this.AdministratorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdministratorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdministratorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AdministratorName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.AdministratorName.Location = new System.Drawing.Point(323, 162);
            this.AdministratorName.Name = "AdministratorName";
            this.AdministratorName.Size = new System.Drawing.Size(394, 23);
            this.AdministratorName.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(204, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Sexe :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(204, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Contact :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(204, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(204, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Photo de l\'administrateur";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::EngineeringProjet.Properties.Resources.Open_Folder_32;
            this.button1.Location = new System.Drawing.Point(41, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 34;
            this.button1.Text = "Choisir l\'image";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(317, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Gestion des administrateurs";
            // 
            // ImageDeProfil
            // 
            this.ImageDeProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageDeProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageDeProfil.Image = global::EngineeringProjet.Properties.Resources.imageDeProfil1;
            this.ImageDeProfil.Location = new System.Drawing.Point(14, 54);
            this.ImageDeProfil.Name = "ImageDeProfil";
            this.ImageDeProfil.Size = new System.Drawing.Size(185, 188);
            this.ImageDeProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageDeProfil.TabIndex = 32;
            this.ImageDeProfil.TabStop = false;
            // 
            // AdministratorPost
            // 
            this.AdministratorPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AdministratorPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdministratorPost.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.AdministratorPost.Location = new System.Drawing.Point(325, 287);
            this.AdministratorPost.Name = "AdministratorPost";
            this.AdministratorPost.Size = new System.Drawing.Size(392, 23);
            this.AdministratorPost.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(206, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Poste :";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSplitContainer1.Grid = this.ListeDesAdministrateurs;
            this.gridSplitContainer1.Location = new System.Drawing.Point(723, 48);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.ListeDesAdministrateurs);
            this.gridSplitContainer1.Size = new System.Drawing.Size(350, 348);
            this.gridSplitContainer1.TabIndex = 60;
            // 
            // ListeDesAdministrateurs
            // 
            this.ListeDesAdministrateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeDesAdministrateurs.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ListeDesAdministrateurs.Location = new System.Drawing.Point(0, 0);
            this.ListeDesAdministrateurs.MainView = this.advBandedGridView1;
            this.ListeDesAdministrateurs.Name = "ListeDesAdministrateurs";
            this.ListeDesAdministrateurs.Size = new System.Drawing.Size(350, 348);
            this.ListeDesAdministrateurs.TabIndex = 34;
            this.ListeDesAdministrateurs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1,
            this.gridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.advBandedGridView1.FixedLineWidth = 3;
            this.advBandedGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.advBandedGridView1.GridControl = this.ListeDesAdministrateurs;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.advBandedGridView1.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.advBandedGridView1.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.advBandedGridView1.OptionsBehavior.KeepGroupExpandedOnSorting = false;
            this.advBandedGridView1.OptionsBehavior.ReadOnly = true;
            this.advBandedGridView1.OptionsCustomization.AllowColumnMoving = false;
            this.advBandedGridView1.OptionsCustomization.AllowColumnResizing = false;
            this.advBandedGridView1.OptionsCustomization.AllowRowSizing = true;
            this.advBandedGridView1.OptionsFind.AlwaysVisible = true;
            this.advBandedGridView1.OptionsFind.FindNullPrompt = "Entrer le mot à rechercher...";
            this.advBandedGridView1.OptionsPrint.AutoWidth = false;
            this.advBandedGridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.advBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridView1.OptionsView.AllowGlyphSkinning = true;
            this.advBandedGridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.advBandedGridView1.OptionsView.ShowBands = false;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            this.advBandedGridView1.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Employés de l\'entreprise";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 114;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.ListeDesAdministrateurs;
            this.gridView1.Name = "gridView1";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::EngineeringProjet.Properties.Resources.Microsoft_Excel_2_32;
            this.button5.Location = new System.Drawing.Point(723, 433);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 39);
            this.button5.TabIndex = 61;
            this.button5.Text = "Exporter la base de données";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AdministratorNb
            // 
            this.AdministratorNb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AdministratorNb.AutoSize = true;
            this.AdministratorNb.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.AdministratorNb.Location = new System.Drawing.Point(946, 399);
            this.AdministratorNb.Name = "AdministratorNb";
            this.AdministratorNb.Size = new System.Drawing.Size(18, 18);
            this.AdministratorNb.TabIndex = 64;
            this.AdministratorNb.Text = "0";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(720, 399);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 18);
            this.label14.TabIndex = 63;
            this.label14.Text = "Nombres d\'administrateurs :";
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.max.Location = new System.Drawing.Point(987, 27);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(18, 18);
            this.max.TabIndex = 66;
            this.max.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(933, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 65;
            this.label8.Text = "Max :";
            // 
            // reportGender
            // 
            this.reportGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reportGender.AutoSize = true;
            this.reportGender.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.reportGender.Location = new System.Drawing.Point(2, 335);
            this.reportGender.Name = "reportGender";
            this.reportGender.Size = new System.Drawing.Size(45, 18);
            this.reportGender.TabIndex = 73;
            this.reportGender.Text = "Sexe";
            this.reportGender.TextChanged += new System.EventHandler(this.reportGender_TextChanged);
            // 
            // GestionDeLAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 484);
            this.Controls.Add(this.reportGender);
            this.Controls.Add(this.max);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AdministratorNb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.AdministratorPost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ImagePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AdministratorSalary);
            this.Controls.Add(this.UserProfil);
            this.Controls.Add(this.AdministratorId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AdministratorContact);
            this.Controls.Add(this.Feminin);
            this.Controls.Add(this.Masculin);
            this.Controls.Add(this.AdministratorSurName);
            this.Controls.Add(this.AdministratorName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageDeProfil);
            this.Name = "GestionDeLAdministration";
            this.Text = "Gestion de l\'administration";
            this.Load += new System.EventHandler(this.GestionDeLAdministration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdministratorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDeProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesAdministrateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ImagePath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label UserProfil;
        private System.Windows.Forms.TextBox AdministratorId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox AdministratorSalary;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource AdministratorBindingSource;
        private System.Windows.Forms.TextBox AdministratorContact;
        private System.Windows.Forms.RadioButton Feminin;
        private System.Windows.Forms.RadioButton Masculin;
        private System.Windows.Forms.TextBox AdministratorSurName;
        private System.Windows.Forms.TextBox AdministratorName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImageDeProfil;
        private System.Windows.Forms.TextBox AdministratorPost;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl ListeDesAdministrateurs;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label AdministratorNb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label reportGender;

    }
}