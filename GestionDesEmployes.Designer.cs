namespace EngineeringProjet
{
    partial class GestionDesEmployes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.EmployeeSurName = new System.Windows.Forms.TextBox();
            this.Masculin = new System.Windows.Forms.RadioButton();
            this.Feminin = new System.Windows.Forms.RadioButton();
            this.EmployeePost = new System.Windows.Forms.ComboBox();
            this.EmployeeContact = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.StageOptions = new System.Windows.Forms.GroupBox();
            this.EmployeeEndOfStage = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.EmployeeStageSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EmployeeId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.UserProfil = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ImagePath = new System.Windows.Forms.Label();
            this.EmployeeStartDate = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ImageDeProfil = new System.Windows.Forms.PictureBox();
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ListeDesEmployés = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.reportGenerator1 = new DevExpress.XtraReports.ReportGeneration.ReportGenerator(this.components);
            this.max = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EmployeeNb = new System.Windows.Forms.Label();
            this.reportGender = new System.Windows.Forms.Label();
            this.StageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDeProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesEmployés)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(350, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion des employés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(36, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Photo de l\'employé";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(203, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(203, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prenom :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(203, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contact :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(203, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date de départ :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(203, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Poste :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(203, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Paramètre de stage ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(203, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sexe :";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EmployeeName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.EmployeeName.Location = new System.Drawing.Point(356, 136);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(344, 23);
            this.EmployeeName.TabIndex = 11;
            // 
            // EmployeeSurName
            // 
            this.EmployeeSurName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeSurName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeSurName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.EmployeeSurName.Location = new System.Drawing.Point(356, 182);
            this.EmployeeSurName.Name = "EmployeeSurName";
            this.EmployeeSurName.Size = new System.Drawing.Size(344, 23);
            this.EmployeeSurName.TabIndex = 12;
            // 
            // Masculin
            // 
            this.Masculin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Masculin.AutoSize = true;
            this.Masculin.Checked = true;
            this.Masculin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Masculin.Location = new System.Drawing.Point(366, 231);
            this.Masculin.Name = "Masculin";
            this.Masculin.Size = new System.Drawing.Size(64, 17);
            this.Masculin.TabIndex = 13;
            this.Masculin.TabStop = true;
            this.Masculin.Text = "Masculin";
            this.Masculin.UseVisualStyleBackColor = true;
            // 
            // Feminin
            // 
            this.Feminin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Feminin.AutoSize = true;
            this.Feminin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Feminin.Location = new System.Drawing.Point(640, 232);
            this.Feminin.Name = "Feminin";
            this.Feminin.Size = new System.Drawing.Size(60, 17);
            this.Feminin.TabIndex = 14;
            this.Feminin.Text = "Feminin";
            this.Feminin.UseVisualStyleBackColor = true;
            // 
            // EmployeePost
            // 
            this.EmployeePost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeePost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeePost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeePost.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.EmployeePost.FormattingEnabled = true;
            this.EmployeePost.Location = new System.Drawing.Point(356, 313);
            this.EmployeePost.Name = "EmployeePost";
            this.EmployeePost.Size = new System.Drawing.Size(344, 23);
            this.EmployeePost.Sorted = true;
            this.EmployeePost.TabIndex = 16;
            this.EmployeePost.SelectedIndexChanged += new System.EventHandler(this.EmployeePost_SelectedIndexChanged);
            // 
            // EmployeeContact
            // 
            this.EmployeeContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeContact.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.EmployeeContact.Location = new System.Drawing.Point(356, 352);
            this.EmployeeContact.Name = "EmployeeContact";
            this.EmployeeContact.Size = new System.Drawing.Size(344, 23);
            this.EmployeeContact.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(521, 413);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Activer les paramètres de stage";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // StageOptions
            // 
            this.StageOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StageOptions.Controls.Add(this.EmployeeEndOfStage);
            this.StageOptions.Controls.Add(this.label12);
            this.StageOptions.Controls.Add(this.EmployeeStageSalary);
            this.StageOptions.Controls.Add(this.label10);
            this.StageOptions.Enabled = false;
            this.StageOptions.Location = new System.Drawing.Point(206, 462);
            this.StageOptions.Name = "StageOptions";
            this.StageOptions.Size = new System.Drawing.Size(494, 132);
            this.StageOptions.TabIndex = 19;
            this.StageOptions.TabStop = false;
            this.StageOptions.Text = "Stagiaire";
            // 
            // EmployeeEndOfStage
            // 
            this.EmployeeEndOfStage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeEndOfStage.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.EmployeeEndOfStage.Location = new System.Drawing.Point(150, 32);
            this.EmployeeEndOfStage.Name = "EmployeeEndOfStage";
            this.EmployeeEndOfStage.Size = new System.Drawing.Size(338, 23);
            this.EmployeeEndOfStage.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(9, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 18);
            this.label12.TabIndex = 28;
            this.label12.Text = "Fin du stage :";
            // 
            // EmployeeStageSalary
            // 
            this.EmployeeStageSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeStageSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeStageSalary.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.EmployeeStageSalary.Location = new System.Drawing.Point(150, 75);
            this.EmployeeStageSalary.Name = "EmployeeStageSalary";
            this.EmployeeStageSalary.Size = new System.Drawing.Size(338, 23);
            this.EmployeeStageSalary.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(9, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Salaire :";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::EngineeringProjet.Properties.Resources.Delete;
            this.button3.Location = new System.Drawing.Point(440, 624);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 39);
            this.button3.TabIndex = 21;
            this.button3.Text = "Virer";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::EngineeringProjet.Properties.Resources.Create;
            this.button4.Location = new System.Drawing.Point(206, 624);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 39);
            this.button4.TabIndex = 22;
            this.button4.Text = "&Ajouter";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EmployeeId
            // 
            this.EmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeId.Enabled = false;
            this.EmployeeId.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.EmployeeId.Location = new System.Drawing.Point(356, 94);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(209, 23);
            this.EmployeeId.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(203, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "Id :";
            // 
            // UserProfil
            // 
            this.UserProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserProfil.AutoSize = true;
            this.UserProfil.Font = new System.Drawing.Font("Tahoma", 11F);
            this.UserProfil.Location = new System.Drawing.Point(9, 645);
            this.UserProfil.Name = "UserProfil";
            this.UserProfil.Size = new System.Drawing.Size(105, 18);
            this.UserProfil.TabIndex = 27;
            this.UserProfil.Text = "Choisir un profil";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::EngineeringProjet.Properties.Resources.Modify;
            this.button2.Location = new System.Drawing.Point(323, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 39);
            this.button2.TabIndex = 28;
            this.button2.Text = "Modifier";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImagePath
            // 
            this.ImagePath.AutoSize = true;
            this.ImagePath.Font = new System.Drawing.Font("SimSun", 3F);
            this.ImagePath.Location = new System.Drawing.Point(8, 242);
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.Size = new System.Drawing.Size(37, 4);
            this.ImagePath.TabIndex = 29;
            this.ImagePath.Text = "Chemin de l\'image";
            this.ImagePath.TextChanged += new System.EventHandler(this.ImagePath_TextChanged);
            // 
            // EmployeeStartDate
            // 
            this.EmployeeStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeStartDate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.EmployeeStartDate.Location = new System.Drawing.Point(356, 264);
            this.EmployeeStartDate.Name = "EmployeeStartDate";
            this.EmployeeStartDate.Size = new System.Drawing.Size(344, 23);
            this.EmployeeStartDate.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(703, 597);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "Nombres d\'employés :";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::EngineeringProjet.Properties.Resources.Open_Folder_32;
            this.button1.Location = new System.Drawing.Point(39, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Choisir l\'image";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImageDeProfil
            // 
            this.ImageDeProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageDeProfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImageDeProfil.Image = global::EngineeringProjet.Properties.Resources.imageDeProfil1;
            this.ImageDeProfil.Location = new System.Drawing.Point(12, 54);
            this.ImageDeProfil.Name = "ImageDeProfil";
            this.ImageDeProfil.Size = new System.Drawing.Size(185, 188);
            this.ImageDeProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageDeProfil.TabIndex = 1;
            this.ImageDeProfil.TabStop = false;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "bandedGridColumn1";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            // 
            // ListeDesEmployés
            // 
            this.ListeDesEmployés.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeDesEmployés.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ListeDesEmployés.Location = new System.Drawing.Point(0, 0);
            this.ListeDesEmployés.MainView = this.advBandedGridView1;
            this.ListeDesEmployés.Name = "ListeDesEmployés";
            this.ListeDesEmployés.Size = new System.Drawing.Size(350, 561);
            this.ListeDesEmployés.TabIndex = 34;
            this.ListeDesEmployés.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1,
            this.gridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.advBandedGridView1.GridControl = this.ListeDesEmployés;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.advBandedGridView1.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.advBandedGridView1.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.advBandedGridView1.OptionsBehavior.KeepGroupExpandedOnSorting = false;
            this.advBandedGridView1.OptionsBehavior.ReadOnly = true;
            this.advBandedGridView1.OptionsCustomization.AllowColumnMoving = false;
            this.advBandedGridView1.OptionsCustomization.AllowColumnResizing = false;
            this.advBandedGridView1.OptionsFind.AlwaysVisible = true;
            this.advBandedGridView1.OptionsFind.FindNullPrompt = "Entrer le mot à rechercher...";
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
            this.gridView1.GridControl = this.ListeDesEmployés;
            this.gridView1.Name = "gridView1";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSplitContainer1.Grid = this.ListeDesEmployés;
            this.gridSplitContainer1.Location = new System.Drawing.Point(706, 33);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.ListeDesEmployés);
            this.gridSplitContainer1.Size = new System.Drawing.Size(350, 561);
            this.gridSplitContainer1.TabIndex = 34;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::EngineeringProjet.Properties.Resources.Text_preview;
            this.button6.Location = new System.Drawing.Point(889, 624);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 39);
            this.button6.TabIndex = 64;
            this.button6.Text = "Visualiser le rapport de cet employé";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::EngineeringProjet.Properties.Resources.Microsoft_Excel_2_32;
            this.button5.Location = new System.Drawing.Point(706, 624);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 39);
            this.button5.TabIndex = 63;
            this.button5.Text = "Exporter la base de données";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.max.Location = new System.Drawing.Point(1012, 597);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(18, 18);
            this.max.TabIndex = 68;
            this.max.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(958, 597);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 67;
            this.label11.Text = "Max :";
            // 
            // EmployeeNb
            // 
            this.EmployeeNb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeNb.AutoSize = true;
            this.EmployeeNb.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.EmployeeNb.Location = new System.Drawing.Point(881, 597);
            this.EmployeeNb.Name = "EmployeeNb";
            this.EmployeeNb.Size = new System.Drawing.Size(18, 18);
            this.EmployeeNb.TabIndex = 71;
            this.EmployeeNb.Text = "0";
            // 
            // reportGender
            // 
            this.reportGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reportGender.AutoSize = true;
            this.reportGender.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.reportGender.Location = new System.Drawing.Point(12, 318);
            this.reportGender.Name = "reportGender";
            this.reportGender.Size = new System.Drawing.Size(45, 18);
            this.reportGender.TabIndex = 72;
            this.reportGender.Text = "Sexe";
            this.reportGender.TextChanged += new System.EventHandler(this.reportGender_TextChanged);
            // 
            // GestionDesEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 675);
            this.Controls.Add(this.reportGender);
            this.Controls.Add(this.EmployeeNb);
            this.Controls.Add(this.max);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.EmployeeStartDate);
            this.Controls.Add(this.ImagePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UserProfil);
            this.Controls.Add(this.EmployeeId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.StageOptions);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.EmployeeContact);
            this.Controls.Add(this.EmployeePost);
            this.Controls.Add(this.Feminin);
            this.Controls.Add(this.Masculin);
            this.Controls.Add(this.EmployeeSurName);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageDeProfil);
            this.Name = "GestionDesEmployes";
            this.Text = "Gestion des employés";
            this.Load += new System.EventHandler(this.GestionDesEmployes_Load);
            this.StageOptions.ResumeLayout(false);
            this.StageOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDeProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesEmployés)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageDeProfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.TextBox EmployeeSurName;
        private System.Windows.Forms.RadioButton Masculin;
        private System.Windows.Forms.RadioButton Feminin;
        private System.Windows.Forms.ComboBox EmployeePost;
        private System.Windows.Forms.TextBox EmployeeContact;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox StageOptions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox EmployeeStageSalary;
        private System.Windows.Forms.TextBox EmployeeId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label UserProfil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ImagePath;
        private System.Windows.Forms.DateTimePicker EmployeeStartDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker EmployeeEndOfStage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private System.Windows.Forms.BindingSource PostBindingSource;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.GridControl ListeDesEmployés;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraReports.ReportGeneration.ReportGenerator reportGenerator1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label EmployeeNb;
        private System.Windows.Forms.Label reportGender;
    }
}