using System;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;
using TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters;

namespace TdB_Odyssee.UserControlLibrary
{
    public partial class ucTdbNational : UserControl
    {
        public ucTdbNational()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            tDB_NATIONALTableAdapter.Fill(dsTdbOdyssee.TDB_NATIONAL);
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
    }
}
