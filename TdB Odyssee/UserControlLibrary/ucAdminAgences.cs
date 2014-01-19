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
    public partial class ucAdminAgences : UserControl
    {
        private SaveFileDialog saveFileDialog;
        private bool exportVisualSettings;
        private bool majMultipleEnCours = false;

        public ucAdminAgences()
        {
            InitializeComponent();
        }

        internal void Init()
        {
            tDB_AGENCETableAdapter.Fill(dsTdbOdyssee.TDB_AGENCE);
            radGridView1.TableElement.BackColor = Color.Transparent;
        }

        private void radGridView1_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.tDBAGENCEBindingSource.EndEdit();
            this.tDB_AGENCETableAdapter.Update(dsTdbOdyssee);
        }

        private void radGridView1_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            DataRowView dataRowView = e.Rows[0].DataBoundItem as DataRowView;
            DataRow row = dataRowView.Row;

            this.tDB_AGENCETableAdapter.Update(row);
        }

        private void radGridView1_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            DataRowView dataRowView = e.Rows[0].DataBoundItem as DataRowView;
            DataRow row = dataRowView.Row;

            this.tDB_AGENCETableAdapter.Delete(int.Parse(row["ID_AGENCE"].ToString()));
        }

    }
}
