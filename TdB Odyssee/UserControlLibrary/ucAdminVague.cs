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
    public partial class ucAdminVague : UserControl
    {
        public ucAdminVague()
        {
            InitializeComponent();
            rgvVague.TableElement.BackColor = Color.Transparent;
        }

        internal void Init()
        {
            tDB_VAGUETableAdapter.Fill(dsTdbOdyssee.TDB_VAGUE);
        }

        private void btnExportRapproClientCateg_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rgvVague_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.tDBVAGUEBindingSource.EndEdit();
            this.tDB_VAGUETableAdapter.Update(dsTdbOdyssee);
        }

        private void rgvVague_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            DataRowView dataRowView = e.Rows[0].DataBoundItem as DataRowView;
            DataRow row = dataRowView.Row;

            this.tDB_VAGUETableAdapter.Update(row);
        }

        private void rgvVague_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            DataRowView dataRowView = e.Rows[0].DataBoundItem as DataRowView;
            DataRow row = dataRowView.Row;

            this.tDB_VAGUETableAdapter.Delete(int.Parse(row["ID_VAGUE"].ToString()), row["NOM_VAGUE"].ToString(), Convert.ToDateTime(row["DATE_VAGUE"].ToString()));
        }

    }
}
