namespace EngineeringProjet
{
    partial class GestionDesGains
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductUnitedPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.TotalReturn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.ReturnsDay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.OthersReturns = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReturnAdd = new System.Windows.Forms.Button();
            this.ReturnDelete = new System.Windows.Forms.Button();
            this.TotalGain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UserProfil = new System.Windows.Forms.Label();
            this.GainBindingSouce = new System.Windows.Forms.BindingSource(this.components);
            this.ReturnId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.ListeDesRecettes = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ReturnNb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainBindingSouce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesRecettes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(257, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des Recettes Journalières";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ProductUnitedPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Quantity);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ProductList);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vente d\'un produit";
            // 
            // ProductUnitedPrice
            // 
            this.ProductUnitedPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductUnitedPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductUnitedPrice.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.ProductUnitedPrice.Location = new System.Drawing.Point(136, 73);
            this.ProductUnitedPrice.Name = "ProductUnitedPrice";
            this.ProductUnitedPrice.ReadOnly = true;
            this.ProductUnitedPrice.Size = new System.Drawing.Size(179, 25);
            this.ProductUnitedPrice.TabIndex = 44;
            this.ProductUnitedPrice.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "prix unitaire :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(371, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Quantité :";
            // 
            // Quantity
            // 
            this.Quantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Quantity.Location = new System.Drawing.Point(526, 35);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(120, 25);
            this.Quantity.TabIndex = 30;
            this.Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(7, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "Produit :";
            // 
            // ProductList
            // 
            this.ProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductList.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(85, 33);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(230, 23);
            this.ProductList.TabIndex = 28;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // TotalReturn
            // 
            this.TotalReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalReturn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.TotalReturn.Location = new System.Drawing.Point(214, 402);
            this.TotalReturn.Name = "TotalReturn";
            this.TotalReturn.ReadOnly = true;
            this.TotalReturn.Size = new System.Drawing.Size(318, 25);
            this.TotalReturn.TabIndex = 23;
            this.TotalReturn.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Recette totale :";
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Add.Location = new System.Drawing.Point(501, 335);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(162, 43);
            this.Add.TabIndex = 32;
            this.Add.Text = "Ajouter à La somme\r\nde vente.";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ReturnsDay
            // 
            this.ReturnsDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnsDay.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.ReturnsDay.Location = new System.Drawing.Point(214, 256);
            this.ReturnsDay.Name = "ReturnsDay";
            this.ReturnsDay.Size = new System.Drawing.Size(449, 25);
            this.ReturnsDay.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Jour :";
            // 
            // OthersReturns
            // 
            this.OthersReturns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OthersReturns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OthersReturns.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.OthersReturns.Location = new System.Drawing.Point(214, 304);
            this.OthersReturns.Name = "OthersReturns";
            this.OthersReturns.Size = new System.Drawing.Size(449, 25);
            this.OthersReturns.TabIndex = 35;
            this.OthersReturns.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Autres :";
            // 
            // ReturnAdd
            // 
            this.ReturnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReturnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.ReturnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnAdd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ReturnAdd.ForeColor = System.Drawing.Color.White;
            this.ReturnAdd.Image = global::EngineeringProjet.Properties.Resources.Create;
            this.ReturnAdd.Location = new System.Drawing.Point(12, 463);
            this.ReturnAdd.Name = "ReturnAdd";
            this.ReturnAdd.Size = new System.Drawing.Size(162, 42);
            this.ReturnAdd.TabIndex = 36;
            this.ReturnAdd.Text = "Terminer et ajouter\r\nla recette";
            this.ReturnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReturnAdd.UseVisualStyleBackColor = false;
            this.ReturnAdd.Click += new System.EventHandler(this.ReturnAdd_Click);
            // 
            // ReturnDelete
            // 
            this.ReturnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnDelete.BackColor = System.Drawing.Color.Red;
            this.ReturnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnDelete.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ReturnDelete.ForeColor = System.Drawing.Color.White;
            this.ReturnDelete.Image = global::EngineeringProjet.Properties.Resources.Delete;
            this.ReturnDelete.Location = new System.Drawing.Point(501, 463);
            this.ReturnDelete.Name = "ReturnDelete";
            this.ReturnDelete.Size = new System.Drawing.Size(162, 42);
            this.ReturnDelete.TabIndex = 37;
            this.ReturnDelete.Text = "Supprimer la recette";
            this.ReturnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReturnDelete.UseVisualStyleBackColor = false;
            this.ReturnDelete.Click += new System.EventHandler(this.ReturnDelete_Click);
            // 
            // TotalGain
            // 
            this.TotalGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalGain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalGain.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.TotalGain.Location = new System.Drawing.Point(782, 58);
            this.TotalGain.Name = "TotalGain";
            this.TotalGain.ReadOnly = true;
            this.TotalGain.Size = new System.Drawing.Size(239, 25);
            this.TotalGain.TabIndex = 38;
            this.TotalGain.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(677, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Gain totale :";
            // 
            // UserProfil
            // 
            this.UserProfil.AutoSize = true;
            this.UserProfil.Font = new System.Drawing.Font("Tahoma", 11F);
            this.UserProfil.Location = new System.Drawing.Point(9, 9);
            this.UserProfil.Name = "UserProfil";
            this.UserProfil.Size = new System.Drawing.Size(105, 18);
            this.UserProfil.TabIndex = 40;
            this.UserProfil.Text = "Choisir un profil";
            // 
            // ReturnId
            // 
            this.ReturnId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReturnId.Enabled = false;
            this.ReturnId.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.ReturnId.Location = new System.Drawing.Point(214, 89);
            this.ReturnId.Name = "ReturnId";
            this.ReturnId.Size = new System.Drawing.Size(449, 25);
            this.ReturnId.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "N° de recette :";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.button1.Location = new System.Drawing.Point(538, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 43;
            this.button1.Text = " Vider la recette";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSplitContainer1.Grid = this.ListeDesRecettes;
            this.gridSplitContainer1.Location = new System.Drawing.Point(669, 89);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.ListeDesRecettes);
            this.gridSplitContainer1.Size = new System.Drawing.Size(352, 348);
            this.gridSplitContainer1.TabIndex = 61;
            // 
            // ListeDesRecettes
            // 
            this.ListeDesRecettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeDesRecettes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ListeDesRecettes.Location = new System.Drawing.Point(0, 0);
            this.ListeDesRecettes.MainView = this.layoutView1;
            this.ListeDesRecettes.Name = "ListeDesRecettes";
            this.ListeDesRecettes.Size = new System.Drawing.Size(352, 348);
            this.ListeDesRecettes.TabIndex = 34;
            this.ListeDesRecettes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1,
            this.gridView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.CardCaption.BorderColor = System.Drawing.Color.Red;
            this.layoutView1.Appearance.CardCaption.Font = new System.Drawing.Font("Stencil", 9F);
            this.layoutView1.Appearance.CardCaption.Options.UseBorderColor = true;
            this.layoutView1.Appearance.CardCaption.Options.UseFont = true;
            this.layoutView1.Appearance.FieldCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.layoutView1.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutView1.Appearance.FieldCaption.Options.UseFont = true;
            this.layoutView1.Appearance.FieldCaption.Options.UseForeColor = true;
            this.layoutView1.GridControl = this.ListeDesRecettes;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.AutoFocusNewCard = true;
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsBehavior.ReadOnly = true;
            this.layoutView1.OptionsCustomization.ShowGroupCardCaptions = false;
            this.layoutView1.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.CustomSize;
            this.layoutView1.OptionsView.ShowCardFieldBorders = true;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.ListeDesRecettes;
            this.gridView1.Name = "gridView1";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::EngineeringProjet.Properties.Resources.Microsoft_Excel_2_32;
            this.button5.Location = new System.Drawing.Point(844, 463);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 42);
            this.button5.TabIndex = 62;
            this.button5.Text = "Exporter la base de données";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(669, 440);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 18);
            this.label14.TabIndex = 63;
            this.label14.Text = "Nombres de recettes :";
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.max.Location = new System.Drawing.Point(990, 440);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(18, 18);
            this.max.TabIndex = 66;
            this.max.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(936, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 65;
            this.label10.Text = "Max :";
            // 
            // ReturnNb
            // 
            this.ReturnNb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnNb.AutoSize = true;
            this.ReturnNb.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.ReturnNb.Location = new System.Drawing.Point(847, 440);
            this.ReturnNb.Name = "ReturnNb";
            this.ReturnNb.Size = new System.Drawing.Size(18, 18);
            this.ReturnNb.TabIndex = 67;
            this.ReturnNb.Text = "0";
            // 
            // GestionDesGains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 517);
            this.Controls.Add(this.ReturnNb);
            this.Controls.Add(this.max);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UserProfil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalGain);
            this.Controls.Add(this.ReturnDelete);
            this.Controls.Add(this.ReturnAdd);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.OthersReturns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReturnsDay);
            this.Controls.Add(this.TotalReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "GestionDesGains";
            this.Text = "GestionDesGains";
            this.Load += new System.EventHandler(this.GestionDesGains_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainBindingSouce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesRecettes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ProductList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TotalReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DateTimePicker ReturnsDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OthersReturns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ReturnAdd;
        private System.Windows.Forms.Button ReturnDelete;
        private System.Windows.Forms.TextBox TotalGain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label UserProfil;
        private System.Windows.Forms.BindingSource GainBindingSouce;
        private System.Windows.Forms.TextBox ReturnId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProductUnitedPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl ListeDesRecettes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ReturnNb;
    }
}