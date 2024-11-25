namespace EngineeringProjet
{
    partial class GestionDesPostes
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PostId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PostSalary = new System.Windows.Forms.TextBox();
            this.PostName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PostDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserProfil = new System.Windows.Forms.Label();
            this.PostBindingSouce = new System.Windows.Forms.BindingSource();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.ListeDesPostes = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PostNb = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PostBindingSouce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesPostes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(923, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 440);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(302, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des postes";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(4, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 39);
            this.button2.TabIndex = 37;
            this.button2.Text = "Modifier";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PostId
            // 
            this.PostId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PostId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostId.Enabled = false;
            this.PostId.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PostId.Location = new System.Drawing.Point(154, 115);
            this.PostId.Name = "PostId";
            this.PostId.Size = new System.Drawing.Size(230, 23);
            this.PostId.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(16, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 18);
            this.label13.TabIndex = 35;
            this.label13.Text = "Id :";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Snap ITC", 12F);
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(121, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 39);
            this.button4.TabIndex = 34;
            this.button4.Text = "&Ajouter le poste";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(339, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 39);
            this.button3.TabIndex = 33;
            this.button3.Text = "Supprimer";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PostSalary
            // 
            this.PostSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PostSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostSalary.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PostSalary.Location = new System.Drawing.Point(154, 241);
            this.PostSalary.Name = "PostSalary";
            this.PostSalary.Size = new System.Drawing.Size(450, 23);
            this.PostSalary.TabIndex = 32;
            // 
            // PostName
            // 
            this.PostName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PostName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PostName.Location = new System.Drawing.Point(154, 178);
            this.PostName.Name = "PostName";
            this.PostName.Size = new System.Drawing.Size(450, 23);
            this.PostName.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 30;
            this.label4.Text = "Salaire de base \r\npour ce poste :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nom de poste :";
            // 
            // PostDescription
            // 
            this.PostDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PostDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostDescription.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PostDescription.Location = new System.Drawing.Point(154, 304);
            this.PostDescription.Multiline = true;
            this.PostDescription.Name = "PostDescription";
            this.PostDescription.Size = new System.Drawing.Size(450, 75);
            this.PostDescription.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Description :";
            // 
            // UserProfil
            // 
            this.UserProfil.AutoSize = true;
            this.UserProfil.Font = new System.Drawing.Font("Tahoma", 11F);
            this.UserProfil.Location = new System.Drawing.Point(10, 9);
            this.UserProfil.Name = "UserProfil";
            this.UserProfil.Size = new System.Drawing.Size(105, 18);
            this.UserProfil.TabIndex = 40;
            this.UserProfil.Text = "Choisir un profil";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSplitContainer1.Grid = this.ListeDesPostes;
            this.gridSplitContainer1.Location = new System.Drawing.Point(610, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.ListeDesPostes);
            this.gridSplitContainer1.Size = new System.Drawing.Size(313, 407);
            this.gridSplitContainer1.TabIndex = 62;
            // 
            // ListeDesPostes
            // 
            this.ListeDesPostes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeDesPostes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ListeDesPostes.Location = new System.Drawing.Point(0, 0);
            this.ListeDesPostes.MainView = this.layoutView1;
            this.ListeDesPostes.Name = "ListeDesPostes";
            this.ListeDesPostes.Size = new System.Drawing.Size(313, 407);
            this.ListeDesPostes.TabIndex = 34;
            this.ListeDesPostes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1,
            this.gridView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.FieldCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.layoutView1.Appearance.FieldCaption.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Bold);
            this.layoutView1.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Blue;
            this.layoutView1.Appearance.FieldCaption.Options.UseBorderColor = true;
            this.layoutView1.Appearance.FieldCaption.Options.UseFont = true;
            this.layoutView1.Appearance.FieldCaption.Options.UseForeColor = true;
            this.layoutView1.GridControl = this.ListeDesPostes;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsBehavior.FocusLeaveOnTab = true;
            this.layoutView1.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.layoutView1.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.layoutView1.OptionsBehavior.ReadOnly = true;
            this.layoutView1.OptionsCustomization.ShowGroupCardCaptions = false;
            this.layoutView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
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
            this.gridView1.GridControl = this.ListeDesPostes;
            this.gridView1.Name = "gridView1";
            // 
            // PostNb
            // 
            this.PostNb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PostNb.AutoSize = true;
            this.PostNb.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.PostNb.Location = new System.Drawing.Point(764, 413);
            this.PostNb.Name = "PostNb";
            this.PostNb.Size = new System.Drawing.Size(18, 18);
            this.PostNb.TabIndex = 66;
            this.PostNb.Text = "0";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(607, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 18);
            this.label14.TabIndex = 65;
            this.label14.Text = "Nombre de postes :";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::EngineeringProjet.Properties.Resources.Microsoft_Excel_2_32;
            this.button5.Location = new System.Drawing.Point(456, 389);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 39);
            this.button5.TabIndex = 67;
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
            this.max.Location = new System.Drawing.Point(872, 413);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(18, 18);
            this.max.TabIndex = 69;
            this.max.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(818, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 68;
            this.label10.Text = "Max :";
            // 
            // GestionDesPostes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 440);
            this.Controls.Add(this.max);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.PostNb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.UserProfil);
            this.Controls.Add(this.PostDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PostId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PostSalary);
            this.Controls.Add(this.PostName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "GestionDesPostes";
            this.Text = "Gestion des postes";
            this.Load += new System.EventHandler(this.GestionDesPostes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PostBindingSouce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeDesPostes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PostId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PostSalary;
        private System.Windows.Forms.TextBox PostName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PostDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UserProfil;
        private System.Windows.Forms.BindingSource PostBindingSouce;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl ListeDesPostes;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.Label PostNb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label label10;
    }
}