namespace TdB_Odyssee.UserControlLibrary
{
    partial class ucTdbFiliere
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
            Telerik.Pivot.Core.PropertyAggregateDescription propertyAggregateDescription1 = new Telerik.Pivot.Core.PropertyAggregateDescription();
            Telerik.Pivot.Core.SumAggregateFunction sumAggregateFunction1 = new Telerik.Pivot.Core.SumAggregateFunction();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription1 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer1 = new Telerik.Pivot.Core.GroupNameComparer();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription2 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer2 = new Telerik.Pivot.Core.GroupNameComparer();
            Telerik.Pivot.Core.PropertyFilterDescription propertyFilterDescription1 = new Telerik.Pivot.Core.PropertyFilterDescription();
            Telerik.Pivot.Core.PropertyFilterDescription propertyFilterDescription2 = new Telerik.Pivot.Core.PropertyFilterDescription();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription3 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer3 = new Telerik.Pivot.Core.GroupNameComparer();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription4 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer4 = new Telerik.Pivot.Core.GroupNameComparer();
            Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription5 = new Telerik.Pivot.Core.PropertyGroupDescription();
            Telerik.Pivot.Core.GroupNameComparer groupNameComparer5 = new Telerik.Pivot.Core.GroupNameComparer();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.bntExpandExport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbExportT0 = new System.Windows.Forms.CheckBox();
            this.cbExportMiseForme = new Telerik.WinControls.UI.RadCheckBox();
            this.btnExportRapproClientCateg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.mainPivotGrid = new Telerik.WinControls.UI.RadPivotGrid();
            this.dsTdbOdyssee = new TdB_Odyssee.Dal.dsTdbOdyssee();
            this.vComptageResultatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vComptageResultatsTableAdapter = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.vComptageResultatsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cbExportMiseForme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vComptageResultatsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(24, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Détail à fiabiliser";
            // 
            // cbExportT0
            // 
            this.cbExportT0.AutoSize = true;
            this.cbExportT0.Location = new System.Drawing.Point(27, 358);
            this.cbExportT0.Name = "cbExportT0";
            this.cbExportT0.Size = new System.Drawing.Size(97, 17);
            this.cbExportT0.TabIndex = 58;
            this.cbExportT0.Text = "Exporter les T0";
            this.cbExportT0.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.bntExpandExport);
            this.splitContainer1.Panel2.Controls.Add(this.shapeContainer1);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 604);
            this.splitContainer1.SplitterDistance = 777;
            this.splitContainer1.TabIndex = 20;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(243, 604);
            this.shapeContainer1.TabIndex = 40;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 28;
            this.lineShape2.X2 = 214;
            this.lineShape2.Y1 = 302;
            this.lineShape2.Y2 = 302;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 27;
            this.lineShape1.X2 = 213;
            this.lineShape1.Y1 = 303;
            this.lineShape1.Y2 = 303;
            // 
            // mainPivotGrid
            // 
            propertyAggregateDescription1.AggregateFunction = sumAggregateFunction1;
            propertyAggregateDescription1.CustomName = null;
            propertyAggregateDescription1.PropertyName = "nb";
            propertyAggregateDescription1.StringFormat = null;
            propertyAggregateDescription1.StringFormatSelector = null;
            propertyAggregateDescription1.TotalFormat = null;
            this.mainPivotGrid.AggregateDescriptions.Add(propertyAggregateDescription1);
            this.mainPivotGrid.ColumnGrandTotalsPosition = Telerik.WinControls.UI.TotalsPos.None;
            propertyGroupDescription1.CustomName = null;
            propertyGroupDescription1.GroupComparer = groupNameComparer1;
            propertyGroupDescription1.GroupFilter = null;
            propertyGroupDescription1.PropertyName = "AGENCE";
            propertyGroupDescription1.ShowGroupsWithNoData = false;
            propertyGroupDescription1.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            propertyGroupDescription2.CustomName = null;
            propertyGroupDescription2.GroupComparer = groupNameComparer2;
            propertyGroupDescription2.GroupFilter = null;
            propertyGroupDescription2.PropertyName = "T0";
            propertyGroupDescription2.ShowGroupsWithNoData = false;
            propertyGroupDescription2.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            this.mainPivotGrid.ColumnGroupDescriptions.Add(propertyGroupDescription1);
            this.mainPivotGrid.ColumnGroupDescriptions.Add(propertyGroupDescription2);
            this.mainPivotGrid.ColumnsSubTotalsPosition = Telerik.WinControls.UI.TotalsPos.None;
            this.mainPivotGrid.DataSource = this.vComptageResultatsBindingSource;
            this.mainPivotGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            propertyFilterDescription1.Condition = null;
            propertyFilterDescription1.CustomName = null;
            propertyFilterDescription1.PropertyName = "VAGUE";
            propertyFilterDescription2.Condition = null;
            propertyFilterDescription2.CustomName = null;
            propertyFilterDescription2.PropertyName = "FIL";
            this.mainPivotGrid.FilterDescriptions.Add(propertyFilterDescription1);
            this.mainPivotGrid.FilterDescriptions.Add(propertyFilterDescription2);
            this.mainPivotGrid.Location = new System.Drawing.Point(0, 0);
            this.mainPivotGrid.Name = "mainPivotGrid";
            propertyGroupDescription3.CustomName = null;
            propertyGroupDescription3.GroupComparer = groupNameComparer3;
            propertyGroupDescription3.GroupFilter = null;
            propertyGroupDescription3.PropertyName = "ID";
            propertyGroupDescription3.ShowGroupsWithNoData = false;
            propertyGroupDescription3.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            propertyGroupDescription4.CustomName = null;
            propertyGroupDescription4.GroupComparer = groupNameComparer4;
            propertyGroupDescription4.GroupFilter = null;
            propertyGroupDescription4.PropertyName = "PRIORITE";
            propertyGroupDescription4.ShowGroupsWithNoData = false;
            propertyGroupDescription4.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            propertyGroupDescription5.CustomName = null;
            propertyGroupDescription5.GroupComparer = groupNameComparer5;
            propertyGroupDescription5.GroupFilter = null;
            propertyGroupDescription5.PropertyName = "CONSIGNE";
            propertyGroupDescription5.ShowGroupsWithNoData = false;
            propertyGroupDescription5.SortOrder = Telerik.Pivot.Core.SortOrder.Ascending;
            this.mainPivotGrid.RowGroupDescriptions.Add(propertyGroupDescription3);
            this.mainPivotGrid.RowGroupDescriptions.Add(propertyGroupDescription4);
            this.mainPivotGrid.RowGroupDescriptions.Add(propertyGroupDescription5);
            this.mainPivotGrid.RowsSubTotalsPosition = Telerik.WinControls.UI.TotalsPos.None;
            this.mainPivotGrid.ShowFilterArea = true;
            this.mainPivotGrid.Size = new System.Drawing.Size(777, 604);
            this.mainPivotGrid.TabIndex = 0;
            this.mainPivotGrid.Text = "radPivotGrid1";
            this.mainPivotGrid.ThemeName = "Office2010Black";
            // 
            // dsTdbOdyssee
            // 
            this.dsTdbOdyssee.DataSetName = "dsTdbOdyssee";
            this.dsTdbOdyssee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vComptageResultatsBindingSource
            // 
            this.vComptageResultatsBindingSource.DataMember = "vComptageResultats";
            this.vComptageResultatsBindingSource.DataSource = this.dsTdbOdyssee;
            // 
            // vComptageResultatsTableAdapter
            // 
            this.vComptageResultatsTableAdapter.ClearBeforeFill = true;
            // 
            // ucTdbFiliere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucTdbFiliere";
            this.Size = new System.Drawing.Size(1024, 604);
            ((System.ComponentModel.ISupportInitialize)(this.cbExportMiseForme)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTdbOdyssee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vComptageResultatsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.Button bntExpandExport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbExportT0;
        private Telerik.WinControls.UI.RadCheckBox cbExportMiseForme;
        private System.Windows.Forms.Button btnExportRapproClientCateg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Telerik.WinControls.UI.RadPivotGrid mainPivotGrid;
        private System.Windows.Forms.BindingSource vComptageResultatsBindingSource;
        private Dal.dsTdbOdyssee dsTdbOdyssee;
        private Dal.dsTdbOdysseeTableAdapters.vComptageResultatsTableAdapter vComptageResultatsTableAdapter;
    }
}
