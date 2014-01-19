using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Telerik.WinControls;
using System.IO;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace TdB_Odyssee.ExportToFile
{
    class ExportToFile
    {
        public string Title;
        public string Message;


        public bool RunExportToExcelML(RadGridView _gvSource, string fileName, string sheetName)//, ref bool openExportFile, string sheetName, ExcelMaxRows maxLines, bool exportVisualSetting)
        {
            ExportToExcelML excelExporter = new ExportToExcelML(_gvSource);
            excelExporter.SheetName = sheetName;
            excelExporter.SummariesExportOption = SummariesOption.ExportAll;

            try
            {
                excelExporter.RunExport(fileName);
                this.Title = "Success";
                this.Message = "Les données ont été exportées avec succès. Voulez-vous ouvrir le fichier ?";
                return true;
            }
            catch (IOException ex)
            {
                this.Title = "I/O Error";
                this.Message = ex.Message;
                return false;
            }
        }

        public bool RunExportToCSV(RadGridView _gvSource, string fileName, ref bool openExportFile, string sheetName, ExcelMaxRows maxLines, bool exportVisualSetting)
        {
            ExportToCSV csvExporter = new ExportToCSV(_gvSource);
            csvExporter.SummariesExportOption = SummariesOption.ExportAll;

            try
            {
                csvExporter.RunExport(fileName);

                this.Title = "Success";
                this.Message = "Les données ont été exportées avec succès. Voulez-vous ouvrir le fichier ?";
                return true;
            }
            catch (IOException ex)
            {
                this.Title = "I/O Error";
                this.Message = ex.Message;
                return false;
            }
        }

        public bool RunExportToPDF(RadGridView _gvSource, string fileName, ref bool openExportFile, string sheetName, ExcelMaxRows maxLines, bool exportVisualSetting)
        {
            ExportToPDF pdfExporter = new ExportToPDF(_gvSource);
            pdfExporter.SummariesExportOption = SummariesOption.ExportAll;
            try
            {
                pdfExporter.RunExport(fileName);

                this.Title = "Export XLS";
                this.Message = "Les données ont été exportées avec succès. Voulez-vous ouvrir le fichier ?";
                return true;
            }
            catch (IOException ex)
            {
                this.Title = "I/O Error";
                this.Message = ex.Message;
                return false;
            }
        }

        public bool RunExportPivotToExcel(RadPivotGrid _rpg, string fileName, string sheetName, bool exportVisualSetting)
        {
            PivotExportToExcelML exporter = new PivotExportToExcelML(_rpg);

            exporter.ExportVisualSettings = exportVisualSetting;
            exporter.SheetName = sheetName;

            try
            {
                exporter.RunExport(fileName);
                this.Title = "Success";
                this.Message = "Les données ont été exportées avec succès. Voulez-vous ouvrir le fichier ?";
                return true;
            }
            catch (IOException ex)
            {
                this.Title = "I/O Error";
                this.Message = ex.Message;
                return false;
            }
        }

        public void RunExportDetails(bool _exportT0)
        {
            string cs = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.TdbOdysseeConnectionString"].ConnectionString;
            var cnx = new SqlConnection(cs);
            SqlCommand cmdL = new SqlCommand();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cnx;
            cmdL.Connection = cnx;
            cmd.CommandType = CommandType.Text;
            cmdL.CommandType = CommandType.Text;
            cmdL.CommandText = "select distinct ID_CONSIGNE, CODE_BASE from dbo.TDB_RESULTAT_CONSIGNE WHERE NUM_ORDRE <> 0";

            if (cnx.State == ConnectionState.Closed)
                cnx.Open();

            SqlDataReader readerL = cmdL.ExecuteReader();
            DataTable dtL = new DataTable();
            dtL.Load(readerL);
            string fileName = "";
            string ligne = "";
            StringBuilder outputContent = new StringBuilder();

            foreach (DataRow drL in dtL.Rows)
            {
                fileName = string.Format(@"{0}\" + drL["CODE_BASE"] + "_"
                                        + drL["ID_CONSIGNE"] + "_"
                                        + DateTime.Now.ToString("yyyyMMdd_HHmmss")
                                        + ".csv", ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.csResultstFilePath"].ToString());

                cmd.CommandText =
                            "select " +
                            "res.CODE_COMMUNE + ';' + replace(res.RESULTAT, '/', ';') " +
                            "from TDB_RESULTAT_CONSIGNE res " +
                            "WHERE res.ID_CONSIGNE = " + drL["ID_CONSIGNE"] + " AND res.CODE_BASE = '" + drL["CODE_BASE"] + "' " +
                            (_exportT0 ? "" : "AND BOOL_T0 = 'N' ") +
                            "order by NUM_ORDRE";

                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader != null && reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        outputContent.AppendLine(reader[i].ToString());
                    }
                }

                StreamWriter outputStream = new StreamWriter(fileName, false);
                outputStream.Write(outputContent.ToString());
                outputStream.Close();
                outputContent.Clear();
                reader.Close();
            }
        }
    }
}
