using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TdB_Odyssee.Extract
{
    class ExportConsigneCycladesFile
    {
        private StringBuilder myInsertResult;
        protected const int _batchSize = 100000;

        public ExportConsigneCycladesFile()
        {
            this.myInsertResult = new StringBuilder();
            
        }

        public string export(int _IdConsigne, string _base, string _t0)
        {
            string _path = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.csFilePath"].ConnectionString;
            int compteur = 0;

            string cs = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.MedocConnectionString"].ConnectionString;
            String delimiter = @"|";
            StringBuilder outputContent = new StringBuilder();
            try
            {
                using (OracleConnection conn = new OracleConnection())
                {
                    conn.ConnectionString = cs;
                    conn.Open();
                    String commandText = getQueryFromidConsigne(_IdConsigne).Replace(@"@@Base", _base);
                    //RadMessageBox.Show(commandText, "Test", MessageBoxButtons.OK, RadMessageIcon.Info);
                    using (OracleCommand cmd = new OracleCommand(commandText))
                    {
                        cmd.Connection = conn;

                        using (OracleDataReader dtReader = cmd.ExecuteReader())
                        {
                            //columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();

                            var columnsNames = Enumerable.Range(0, dtReader.FieldCount).Select(dtReader.GetName).ToArray();

                            //On récupère les indexes des Champs
                            int IndexofCodeBase = -1;
                            int IndexofCodeCommune = -1;
                            List<int> ListIndexOfResultatField = new List<int>();
                            string ListChampsResultat = "";

                            for (int i = 0; i < columnsNames.Count(); i++)
                            {
                                switch (columnsNames[i].ToString())
                                {
                                    case "CODE_BASE":
                                        IndexofCodeBase = i;
                                        break;
                                    case "CODE_COMMUNE":
                                        IndexofCodeCommune = i;
                                        break;
                                    default:
                                        ListIndexOfResultatField.Add(i);
                                        ListChampsResultat += columnsNames[i].ToString() + @"/";
                                        break;
                                }
                            }
                            ListChampsResultat = ListChampsResultat.EndsWith("/") ? ListChampsResultat.Substring(0, ListChampsResultat.Length - 1) : ListChampsResultat;
                            //On génère la premiere ligne
                            outputContent.AppendLine("0|" + _IdConsigne.ToString() + "|" + _base + "|CODE_COMMUNE|" + _t0 + "|" + ListChampsResultat);

                            while (dtReader != null && dtReader.Read())
                            {
                                //NUM_ORDRE
                                outputContent.Append((compteur + 1).ToString());
                                outputContent.Append(delimiter);

                                //ID_CONSIGNE
                                outputContent.Append(_IdConsigne.ToString());
                                outputContent.Append(delimiter);

                                //CODE_BASE
                                outputContent.Append(dtReader[IndexofCodeBase]);
                                outputContent.Append(delimiter);

                                //CODE_COMMUNE
                                outputContent.Append(dtReader[IndexofCodeCommune]);
                                outputContent.Append(delimiter);

                                //BOOL_T0
                                outputContent.Append(_t0);
                                outputContent.Append(delimiter);

                                //RESULTAT
                                for (int i = 0; i < ListIndexOfResultatField.Count(); i++)
                                {
                                    outputContent.Append(dtReader[ListIndexOfResultatField[i]]);
                                    outputContent.Append(@"/");
                                }

                                outputContent = outputContent.Replace("/", Environment.NewLine, outputContent.Length - 1, 1);
                                compteur++;
                            }
                        }
                    }
                }
                string _filePath = _path + @"\" + _IdConsigne.ToString() + _base + ".data";

                StreamWriter outputStream = new StreamWriter(_filePath, false);

                //Export
                outputStream.Write(outputContent.ToString());
                outputStream.Close();

                //décommenter si on veut shunter le control de lignes :
                //return _filePath;

                if (compteur != 0)
                    return _filePath;
                else
                    return "Erreur : pas de lignes exportées";
            }
            catch (Exception ex)
            {
                return "Erreur : " + ex.Message;
            }
        }

        private string getQueryFromidConsigne(int _idConsigne)
        {
            Dal.dsTdbOdyssee monDS = new Dal.dsTdbOdyssee();
            var tDB_CONSIGNETableAdapter = new TdB_Odyssee.Dal.dsTdbOdysseeTableAdapters.TDB_CONSIGNETableAdapter();
            tDB_CONSIGNETableAdapter.Fill(monDS.TDB_CONSIGNE);

            var ConsigneQuery = monDS.TDB_CONSIGNE.FindByID_CONSIGNE(_idConsigne);

            return ConsigneQuery.REQUETE_CONSIGNE;
        }

        protected void InsertDataTable(SqlBulkCopy sqlBulkCopy, SqlConnection sqlConnection, DataTable dataTable)
        {
            sqlBulkCopy.WriteToServer(dataTable);

            dataTable.Rows.Clear();
        }
    }
}
