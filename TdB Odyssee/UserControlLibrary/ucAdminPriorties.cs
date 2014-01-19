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
    public partial class ucAdminPriorties : UserControl
    {
        public ucAdminPriorties()
        {
            InitializeComponent();
            rgvVague.TableElement.BackColor = Color.Transparent;
        }

        internal void Init()
        {
            tDB_PRIORITETableAdapter.Fill(dsTdbOdyssee.TDB_PRIORITE);
            
        }

        private void MasterTemplate_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.tDBPRIORITEBindingSource.EndEdit();
            this.tDB_PRIORITETableAdapter.Update(dsTdbOdyssee);
        }

        private void MasterTemplate_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            DataRowView dataRowView = e.Rows[0].DataBoundItem as DataRowView;
            DataRow row = dataRowView.Row;

            this.tDB_PRIORITETableAdapter.Update(row);
        }

        private void MasterTemplate_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            DataRowView dataRowView = e.Rows[0].DataBoundItem as DataRowView;
            DataRow row = dataRowView.Row;

            this.tDB_PRIORITETableAdapter.Delete(int.Parse(row["ID_PRIORITE"].ToString()));
        }

    }
}
