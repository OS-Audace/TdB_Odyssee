namespace TdB_Odyssee.UserControlLibrary
{
    partial class ucTdbAgence
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.vComptageResultatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTdbOdyssee = new TdB_Odyssee.Dal.dsTdbOdyssee();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportRapproClientCateg = new System.Windows.Forms.Button();
            this.cbExportMiseForme = new Telerik.WinControls.UI.RadCheckBox();
            this.cbExportT0 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportDetail = new System.Windows.Forms.Button();
            this.bntExpandExport = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.vComptageResultatsTableAdapter = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.vComptageResultatsTableAdapter();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.mainPivotGrid = new Telerik.WinControls.UI.RadPivotGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vComptageResultatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExportMiseForme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPivotGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainPivotGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btnExportRapproClientCateg);
            this.splitContainer1.Panel2.Controls.Add(this.cbExportMiseForme);
            this.splitContainer1.Panel2.Controls.Add(this.cbExportT0);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnExportDetail);
            this.splitContainer1.Panel2.Controls.Add(this.bntExpandExport);
            this.splitContainer1.Panel2.Controls.Add(this.shapeContainer1);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 604);
            this.splitContainer1.SplitterDistance = 777;
            this.splitContainer1.TabIndex = 22;
            // 
            // vComptageResultatsBindingSource
            // 
            this.vComptageResultatsBindingSource.DataMember = "vComptageResultats";
            this.vComptageResultatsBindingSource.DataSource = this.dsTdbOdyssee;
            // 
            // dsTdbOdyssee
            // 
            this.dsTdbOdyssee.DataSetName = "dsTdbOdyssee";
            this.dsTdbOdyssee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tableau de bord";
            // 
            // btnExportRapproClientCateg
            // 
            this.btnExportRapproClientCateg.Location = new System.Drawing.Point(25, 78);
            this.btnExportRapproClientCateg.Name = "btnExportRapproClientCateg";
            this.btnExportRapproClientCateg.Size = new System.Drawing.Size(84, 23);
            this.btnExportRapproClientCateg.TabIndex = 67;
            this.btnExportRapproClientCateg.Text = "Export";
            this.btnExportRapproClientCateg.UseVisualStyleBackColor = true;
            this.btnExportRapproClientCateg.Click += new System.EventHandler(this.btnExportRapproClientCateg_Click);
            // 
            // cbExportMiseForme
            // 
            this.cbExportMiseForme.Location = new System.Drawing.Point(25, 52);
            this.cbExportMiseForme.Name = "cbExportMiseForme";
            // 
            // 
            // 
            this.cbExportMiseForme.RootElement.StretchHorizontally = true;
            this.cbExportMiseForme.RootElement.StretchVertically = true;
            this.cbExportMiseForme.Size = new System.Drawing.Size(156, 18);
            this.cbExportMiseForme.TabIndex = 65;
            this.cbExportMiseForme.Text = "Conserver la mise en forme";
            // 
            // cbExportT0
            // 
            this.cbExportT0.AutoSize = true;
            this.cbExportT0.Location = new System.Drawing.Point(27, 358);
            this.cbExportT0.Name = "cbExportT0";
            this.cbExportT0.Size = new System.Drawing.Size(97, 17);
            this.cbExportT0.TabIndex = 50;
            this.cbExportT0.Text = "Exporter les T0";
            this.cbExportT0.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(24, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Détail à fiabiliser";
            // 
            // btnExportDetail
            // 
            this.btnExportDetail.Location = new System.Drawing.Point(28, 385);
            this.btnExportDetail.Name = "btnExportDetail";
            this.btnExportDetail.Size = new System.Drawing.Size(84, 23);
            this.btnExportDetail.TabIndex = 49;
            this.btnExportDetail.Text = "Export";
            this.btnExportDetail.UseVisualStyleBackColor = true;
            this.btnExportDetail.Click += new System.EventHandler(this.btnExportDetail_Click);
            // 
            // bntExpandExport
            // 
            this.bntExpandExport.FlatAppearance.BorderSize = 0;
            this.bntExpandExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExpandExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExpandExport.Location = new System.Drawing.Point(2, 2);
            this.bntExpandExport.Name = "bntExpandExport";
            this.bntExpandExport.Size = new System.Drawing.Size(20, 20);
            this.bntExpandExport.TabIndex = 39;
            this.bntExpandExport.Text = ">";
            this.bntExpandExport.UseVisualStyleBackColor = true;
            this.bntExpandExport.Click += new System.EventHandler(this.bntExpandExport_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(243, 604);
            this.shapeContainer1.TabIndex = 40;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 27;
            this.lineShape1.X2 = 213;
            this.lineShape1.Y1 = 303;
            this.lineShape1.Y2 = 303;
            // 
            // vComptageResultatsTableAdapter
            // 
            this.vComptageResultatsTableAdapter.ClearBeforeFill = true;
            // 
            // mainPivotGrid
            // 
            this.mainPivotGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPivotGrid.Location = new System.Drawing.Point(0, 0);
            this.mainPivotGrid.Name = "mainPivotGrid";
            this.mainPivotGrid.Size = new System.Drawing.Size(777, 604);
            this.mainPivotGrid.TabIndex = 0;
            this.mainPivotGrid.Text = "radPivotGrid1";
            this.mainPivotGrid.ThemeName = "Office2010Black";
            // 
            // ucTdbAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucTdbAgence";
            this.Size = new System.Drawing.Size(1024, 604);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vComptageResultatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExportMiseForme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPivotGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportDetail;
        private System.Windows.Forms.Button bntExpandExport;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.BindingSource vComptageResultatsBindingSource;
        private Dal.dsTdbOdyssee dsTdbOdyssee;
        private Dal.dsTdbOdysseeTableAdapters.vComptageResultatsTableAdapter vComptageResultatsTableAdapter;
        private System.Windows.Forms.CheckBox cbExportT0;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportRapproClientCateg;
        private Telerik.WinControls.UI.RadCheckBox cbExportMiseForme;
        private Telerik.WinControls.UI.RadPivotGrid mainPivotGrid;
    }
}
