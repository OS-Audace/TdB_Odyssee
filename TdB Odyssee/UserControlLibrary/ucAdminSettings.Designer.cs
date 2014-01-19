namespace TdB_Odyssee.UserControlLibrary
{
    partial class ucAdminSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbImportDir = new System.Windows.Forms.TextBox();
            this.btnFolderSearch = new System.Windows.Forms.Button();
            this.btnSaveImportDir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTesterBddLocale = new System.Windows.Forms.Button();
            this.btnEnregistrerBddLocale = new System.Windows.Forms.Button();
            this.tbCatalogueLocale = new System.Windows.Forms.TextBox();
            this.tbDatasourceLocale = new System.Windows.Forms.TextBox();
            this.labelCatalogueLocale = new System.Windows.Forms.Label();
            this.labelDatasourceLocale = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbPassServices = new System.Windows.Forms.TextBox();
            this.tbLoginServices = new System.Windows.Forms.TextBox();
            this.tbAliasServices = new System.Windows.Forms.TextBox();
            this.labelPassServices = new System.Windows.Forms.Label();
            this.labelLoginServices = new System.Windows.Forms.Label();
            this.labelAliasServices = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTesterConnexion = new System.Windows.Forms.Button();
            this.btnSaveDataBaseSetting = new System.Windows.Forms.Button();
            this.tbPassMedoc = new System.Windows.Forms.TextBox();
            this.tbLoginMedoc = new System.Windows.Forms.TextBox();
            this.tbAliasMedoc = new System.Windows.Forms.TextBox();
            this.labelPassMedoc = new System.Windows.Forms.Label();
            this.labelLoginMedoc = new System.Windows.Forms.Label();
            this.labelAliasMedoc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbPassGrc = new System.Windows.Forms.TextBox();
            this.tbLoginGrc = new System.Windows.Forms.TextBox();
            this.tbAliasGrc = new System.Windows.Forms.TextBox();
            this.labelPassGrc = new System.Windows.Forms.Label();
            this.labelLoginGrc = new System.Windows.Forms.Label();
            this.labelAliasGrc = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.tbImportDir);
            this.groupBox5.Controls.Add(this.btnFolderSearch);
            this.groupBox5.Controls.Add(this.btnSaveImportDir);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(3, 321);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1002, 100);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exports";
            // 
            // tbImportDir
            // 
            this.tbImportDir.Location = new System.Drawing.Point(173, 19);
            this.tbImportDir.Name = "tbImportDir";
            this.tbImportDir.Size = new System.Drawing.Size(724, 20);
            this.tbImportDir.TabIndex = 21;
            // 
            // btnFolderSearch
            // 
            this.btnFolderSearch.ForeColor = System.Drawing.Color.Black;
            this.btnFolderSearch.Location = new System.Drawing.Point(741, 45);
            this.btnFolderSearch.Name = "btnFolderSearch";
            this.btnFolderSearch.Size = new System.Drawing.Size(75, 23);
            this.btnFolderSearch.TabIndex = 22;
            this.btnFolderSearch.Text = "Parcourir";
            this.btnFolderSearch.UseVisualStyleBackColor = true;
            this.btnFolderSearch.Click += new System.EventHandler(this.btnFolderSearch_Click);
            // 
            // btnSaveImportDir
            // 
            this.btnSaveImportDir.ForeColor = System.Drawing.Color.Black;
            this.btnSaveImportDir.Location = new System.Drawing.Point(822, 45);
            this.btnSaveImportDir.Name = "btnSaveImportDir";
            this.btnSaveImportDir.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImportDir.TabIndex = 23;
            this.btnSaveImportDir.Text = "Enregistrer";
            this.btnSaveImportDir.UseVisualStyleBackColor = true;
            this.btnSaveImportDir.Click += new System.EventHandler(this.btnSaveImportDir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Répertoire cible";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnTesterBddLocale);
            this.groupBox4.Controls.Add(this.btnEnregistrerBddLocale);
            this.groupBox4.Controls.Add(this.tbCatalogueLocale);
            this.groupBox4.Controls.Add(this.tbDatasourceLocale);
            this.groupBox4.Controls.Add(this.labelCatalogueLocale);
            this.groupBox4.Controls.Add(this.labelDatasourceLocale);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(510, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(495, 146);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connexion à la base LOCALE";
            // 
            // btnTesterBddLocale
            // 
            this.btnTesterBddLocale.ForeColor = System.Drawing.Color.Black;
            this.btnTesterBddLocale.Location = new System.Drawing.Point(234, 105);
            this.btnTesterBddLocale.Name = "btnTesterBddLocale";
            this.btnTesterBddLocale.Size = new System.Drawing.Size(75, 23);
            this.btnTesterBddLocale.TabIndex = 18;
            this.btnTesterBddLocale.Text = "Tester";
            this.btnTesterBddLocale.UseVisualStyleBackColor = true;
            this.btnTesterBddLocale.Click += new System.EventHandler(this.btnTesterBddLocale_Click);
            // 
            // btnEnregistrerBddLocale
            // 
            this.btnEnregistrerBddLocale.ForeColor = System.Drawing.Color.Black;
            this.btnEnregistrerBddLocale.Location = new System.Drawing.Point(315, 105);
            this.btnEnregistrerBddLocale.Name = "btnEnregistrerBddLocale";
            this.btnEnregistrerBddLocale.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerBddLocale.TabIndex = 20;
            this.btnEnregistrerBddLocale.Text = "Enregistrer";
            this.btnEnregistrerBddLocale.UseVisualStyleBackColor = true;
            this.btnEnregistrerBddLocale.Click += new System.EventHandler(this.btnEnregistrerBddLocale_Click);
            // 
            // tbCatalogueLocale
            // 
            this.tbCatalogueLocale.Location = new System.Drawing.Point(169, 53);
            this.tbCatalogueLocale.Name = "tbCatalogueLocale";
            this.tbCatalogueLocale.Size = new System.Drawing.Size(221, 20);
            this.tbCatalogueLocale.TabIndex = 17;
            // 
            // tbDatasourceLocale
            // 
            this.tbDatasourceLocale.Location = new System.Drawing.Point(169, 27);
            this.tbDatasourceLocale.Name = "tbDatasourceLocale";
            this.tbDatasourceLocale.Size = new System.Drawing.Size(221, 20);
            this.tbDatasourceLocale.TabIndex = 16;
            // 
            // labelCatalogueLocale
            // 
            this.labelCatalogueLocale.AutoSize = true;
            this.labelCatalogueLocale.Location = new System.Drawing.Point(101, 56);
            this.labelCatalogueLocale.Name = "labelCatalogueLocale";
            this.labelCatalogueLocale.Size = new System.Drawing.Size(55, 13);
            this.labelCatalogueLocale.TabIndex = 0;
            this.labelCatalogueLocale.Text = "Catalogue";
            // 
            // labelDatasourceLocale
            // 
            this.labelDatasourceLocale.AutoSize = true;
            this.labelDatasourceLocale.Location = new System.Drawing.Point(57, 30);
            this.labelDatasourceLocale.Name = "labelDatasourceLocale";
            this.labelDatasourceLocale.Size = new System.Drawing.Size(99, 13);
            this.labelDatasourceLocale.TabIndex = 0;
            this.labelDatasourceLocale.Text = "Data Source (MSS)";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.tbPassServices);
            this.groupBox3.Controls.Add(this.tbLoginServices);
            this.groupBox3.Controls.Add(this.tbAliasServices);
            this.groupBox3.Controls.Add(this.labelPassServices);
            this.groupBox3.Controls.Add(this.labelLoginServices);
            this.groupBox3.Controls.Add(this.labelAliasServices);
            this.groupBox3.Enabled = false;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 146);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connexion à la base REPCLI";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(234, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Tester";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(315, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Enregistrer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tbPassServices
            // 
            this.tbPassServices.Location = new System.Drawing.Point(169, 79);
            this.tbPassServices.Name = "tbPassServices";
            this.tbPassServices.Size = new System.Drawing.Size(221, 20);
            this.tbPassServices.TabIndex = 13;
            // 
            // tbLoginServices
            // 
            this.tbLoginServices.Location = new System.Drawing.Point(169, 53);
            this.tbLoginServices.Name = "tbLoginServices";
            this.tbLoginServices.Size = new System.Drawing.Size(221, 20);
            this.tbLoginServices.TabIndex = 12;
            // 
            // tbAliasServices
            // 
            this.tbAliasServices.Location = new System.Drawing.Point(169, 27);
            this.tbAliasServices.Name = "tbAliasServices";
            this.tbAliasServices.Size = new System.Drawing.Size(221, 20);
            this.tbAliasServices.TabIndex = 11;
            // 
            // labelPassServices
            // 
            this.labelPassServices.AutoSize = true;
            this.labelPassServices.Location = new System.Drawing.Point(103, 82);
            this.labelPassServices.Name = "labelPassServices";
            this.labelPassServices.Size = new System.Drawing.Size(53, 13);
            this.labelPassServices.TabIndex = 0;
            this.labelPassServices.Text = "Password";
            // 
            // labelLoginServices
            // 
            this.labelLoginServices.AutoSize = true;
            this.labelLoginServices.Location = new System.Drawing.Point(123, 56);
            this.labelLoginServices.Name = "labelLoginServices";
            this.labelLoginServices.Size = new System.Drawing.Size(33, 13);
            this.labelLoginServices.TabIndex = 0;
            this.labelLoginServices.Text = "Login";
            // 
            // labelAliasServices
            // 
            this.labelAliasServices.AutoSize = true;
            this.labelAliasServices.Location = new System.Drawing.Point(58, 30);
            this.labelAliasServices.Name = "labelAliasServices";
            this.labelAliasServices.Size = new System.Drawing.Size(102, 13);
            this.labelAliasServices.TabIndex = 0;
            this.labelAliasServices.Text = "Alias REPCLI (MSS)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTesterConnexion);
            this.groupBox1.Controls.Add(this.btnSaveDataBaseSetting);
            this.groupBox1.Controls.Add(this.tbPassMedoc);
            this.groupBox1.Controls.Add(this.tbLoginMedoc);
            this.groupBox1.Controls.Add(this.tbAliasMedoc);
            this.groupBox1.Controls.Add(this.labelPassMedoc);
            this.groupBox1.Controls.Add(this.labelLoginMedoc);
            this.groupBox1.Controls.Add(this.labelAliasMedoc);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 146);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion à la base MEDOC";
            // 
            // btnTesterConnexion
            // 
            this.btnTesterConnexion.ForeColor = System.Drawing.Color.Black;
            this.btnTesterConnexion.Location = new System.Drawing.Point(234, 105);
            this.btnTesterConnexion.Name = "btnTesterConnexion";
            this.btnTesterConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnTesterConnexion.TabIndex = 4;
            this.btnTesterConnexion.Text = "Tester";
            this.btnTesterConnexion.UseVisualStyleBackColor = true;
            this.btnTesterConnexion.Click += new System.EventHandler(this.btnTesterConnexion_Click);
            // 
            // btnSaveDataBaseSetting
            // 
            this.btnSaveDataBaseSetting.Enabled = false;
            this.btnSaveDataBaseSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSaveDataBaseSetting.Location = new System.Drawing.Point(315, 105);
            this.btnSaveDataBaseSetting.Name = "btnSaveDataBaseSetting";
            this.btnSaveDataBaseSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDataBaseSetting.TabIndex = 5;
            this.btnSaveDataBaseSetting.Text = "Enregistrer";
            this.btnSaveDataBaseSetting.UseVisualStyleBackColor = true;
            this.btnSaveDataBaseSetting.Click += new System.EventHandler(this.btnSaveDataBaseSetting_Click);
            // 
            // tbPassMedoc
            // 
            this.tbPassMedoc.Location = new System.Drawing.Point(169, 79);
            this.tbPassMedoc.Name = "tbPassMedoc";
            this.tbPassMedoc.Size = new System.Drawing.Size(221, 20);
            this.tbPassMedoc.TabIndex = 3;
            // 
            // tbLoginMedoc
            // 
            this.tbLoginMedoc.Location = new System.Drawing.Point(169, 53);
            this.tbLoginMedoc.Name = "tbLoginMedoc";
            this.tbLoginMedoc.Size = new System.Drawing.Size(221, 20);
            this.tbLoginMedoc.TabIndex = 2;
            // 
            // tbAliasMedoc
            // 
            this.tbAliasMedoc.Location = new System.Drawing.Point(169, 27);
            this.tbAliasMedoc.Name = "tbAliasMedoc";
            this.tbAliasMedoc.Size = new System.Drawing.Size(221, 20);
            this.tbAliasMedoc.TabIndex = 1;
            // 
            // labelPassMedoc
            // 
            this.labelPassMedoc.AutoSize = true;
            this.labelPassMedoc.Location = new System.Drawing.Point(103, 82);
            this.labelPassMedoc.Name = "labelPassMedoc";
            this.labelPassMedoc.Size = new System.Drawing.Size(53, 13);
            this.labelPassMedoc.TabIndex = 0;
            this.labelPassMedoc.Text = "Password";
            // 
            // labelLoginMedoc
            // 
            this.labelLoginMedoc.AutoSize = true;
            this.labelLoginMedoc.Location = new System.Drawing.Point(123, 56);
            this.labelLoginMedoc.Name = "labelLoginMedoc";
            this.labelLoginMedoc.Size = new System.Drawing.Size(33, 13);
            this.labelLoginMedoc.TabIndex = 0;
            this.labelLoginMedoc.Text = "Login";
            // 
            // labelAliasMedoc
            // 
            this.labelAliasMedoc.AutoSize = true;
            this.labelAliasMedoc.Location = new System.Drawing.Point(48, 30);
            this.labelAliasMedoc.Name = "labelAliasMedoc";
            this.labelAliasMedoc.Size = new System.Drawing.Size(111, 13);
            this.labelAliasMedoc.TabIndex = 0;
            this.labelAliasMedoc.Text = "Alias MEDOC (Oracle)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tbPassGrc);
            this.groupBox2.Controls.Add(this.tbLoginGrc);
            this.groupBox2.Controls.Add(this.tbAliasGrc);
            this.groupBox2.Controls.Add(this.labelPassGrc);
            this.groupBox2.Controls.Add(this.labelLoginGrc);
            this.groupBox2.Controls.Add(this.labelAliasGrc);
            this.groupBox2.Enabled = false;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(510, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 146);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connexion à la base GRC";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(234, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tester";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(315, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbPassGrc
            // 
            this.tbPassGrc.Location = new System.Drawing.Point(169, 79);
            this.tbPassGrc.Name = "tbPassGrc";
            this.tbPassGrc.Size = new System.Drawing.Size(221, 20);
            this.tbPassGrc.TabIndex = 8;
            // 
            // tbLoginGrc
            // 
            this.tbLoginGrc.Location = new System.Drawing.Point(169, 53);
            this.tbLoginGrc.Name = "tbLoginGrc";
            this.tbLoginGrc.Size = new System.Drawing.Size(221, 20);
            this.tbLoginGrc.TabIndex = 7;
            // 
            // tbAliasGrc
            // 
            this.tbAliasGrc.Location = new System.Drawing.Point(169, 27);
            this.tbAliasGrc.Name = "tbAliasGrc";
            this.tbAliasGrc.Size = new System.Drawing.Size(221, 20);
            this.tbAliasGrc.TabIndex = 6;
            // 
            // labelPassGrc
            // 
            this.labelPassGrc.AutoSize = true;
            this.labelPassGrc.Location = new System.Drawing.Point(103, 82);
            this.labelPassGrc.Name = "labelPassGrc";
            this.labelPassGrc.Size = new System.Drawing.Size(53, 13);
            this.labelPassGrc.TabIndex = 0;
            this.labelPassGrc.Text = "Password";
            // 
            // labelLoginGrc
            // 
            this.labelLoginGrc.AutoSize = true;
            this.labelLoginGrc.Location = new System.Drawing.Point(123, 56);
            this.labelLoginGrc.Name = "labelLoginGrc";
            this.labelLoginGrc.Size = new System.Drawing.Size(33, 13);
            this.labelLoginGrc.TabIndex = 0;
            this.labelLoginGrc.Text = "Login";
            // 
            // labelAliasGrc
            // 
            this.labelAliasGrc.AutoSize = true;
            this.labelAliasGrc.Location = new System.Drawing.Point(61, 30);
            this.labelAliasGrc.Name = "labelAliasGrc";
            this.labelAliasGrc.Size = new System.Drawing.Size(95, 13);
            this.labelAliasGrc.TabIndex = 0;
            this.labelAliasGrc.Text = "Alias GRC (Oracle)";
            // 
            // ucAdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TdB_Odyssee.Properties.Resources.FOND;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Name = "ucAdminSettings";
            this.Size = new System.Drawing.Size(1008, 554);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbImportDir;
        private System.Windows.Forms.Button btnFolderSearch;
        private System.Windows.Forms.Button btnSaveImportDir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTesterBddLocale;
        private System.Windows.Forms.Button btnEnregistrerBddLocale;
        private System.Windows.Forms.TextBox tbCatalogueLocale;
        private System.Windows.Forms.TextBox tbDatasourceLocale;
        private System.Windows.Forms.Label labelCatalogueLocale;
        private System.Windows.Forms.Label labelDatasourceLocale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbPassServices;
        private System.Windows.Forms.TextBox tbLoginServices;
        private System.Windows.Forms.TextBox tbAliasServices;
        private System.Windows.Forms.Label labelPassServices;
        private System.Windows.Forms.Label labelLoginServices;
        private System.Windows.Forms.Label labelAliasServices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTesterConnexion;
        private System.Windows.Forms.Button btnSaveDataBaseSetting;
        private System.Windows.Forms.TextBox tbPassMedoc;
        private System.Windows.Forms.TextBox tbLoginMedoc;
        private System.Windows.Forms.TextBox tbAliasMedoc;
        private System.Windows.Forms.Label labelPassMedoc;
        private System.Windows.Forms.Label labelLoginMedoc;
        private System.Windows.Forms.Label labelAliasMedoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbPassGrc;
        private System.Windows.Forms.TextBox tbLoginGrc;
        private System.Windows.Forms.TextBox tbAliasGrc;
        private System.Windows.Forms.Label labelPassGrc;
        private System.Windows.Forms.Label labelLoginGrc;
        private System.Windows.Forms.Label labelAliasGrc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
