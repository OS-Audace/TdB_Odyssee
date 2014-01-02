using System;
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
            tDB_FILIERETableAdapter.Fill(dsTdbOdyssee.TDB_FILIERE);
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
