using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TdB_Odyssee.UserControlLibrary
{
    public partial class ucTdbFiliere : UserControl
    {
        public ucTdbFiliere()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            new Dal.dsTdbOdysseeTableAdapters.vComptageResultatsTableAdapter().Fill(dsTdbOdyssee.vComptageResultats);

            bntExpandExport.Text = "<";
            this.splitContainer1.SplitterDistance = this.splitContainer1.Width - 30;
        }

        private void bntExpandExport_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (btn.Text == ">")
            {
                btn.Text = "<";
                this.splitContainer1.SplitterDistance = this.splitContainer1.Width - 30;
            }
            else
            {
                btn.Text = ">";
                this.splitContainer1.SplitterDistance = this.splitContainer1.Width - 245;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnExportRapproClientCateg_Click(object sender, EventArgs e)
        {
            string FilePath =
        string.Format(@"{0}\" + "Tdb_Filliere_"
                            + DateTime.Now.ToString("yyyyMMdd_HHmmss")
                            + ".xls", ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.csExportFilePath"].ToString());

            new ExportToFile.ExportToFile().RunExportPivotToExcel(this.mainPivotGrid, FilePath, "TdbFilliere", true);

            System.Diagnostics.Process.Start(FilePath);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new ExportToFile.ExportToFile().RunExportDetails(cbExportT0.Checked);

            MessageBox.Show("Opération Terminée");

            string FilePath = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.csResultstFilePath"].ConnectionString;

            System.Diagnostics.Process.Start(FilePath);
        }
    }
}
