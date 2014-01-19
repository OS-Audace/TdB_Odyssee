using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace TdB_Odyssee.Extract
{

    class ExportComcycFiles
    {
        private StringBuilder myInsertResult;
        protected const int _batchSize = 100000;

        public ExportComcycFiles()
        {
            this.myInsertResult = new StringBuilder();
        }

        public string exportComcycFiles(string _file)
        {
            myInsertResult.AppendLine("Export COMCYC :");
            myInsertResult.AppendLine(this.export(_file));
            myInsertResult.AppendLine("");

            return myInsertResult.ToString();
        }

        private string export(string _file)
        {

            int compteur = 0;
            DateTime startTime = DateTime.Now;

            string cs = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.MedocConnectionString"].ConnectionString;
            String delimiter = @"|";
            StringBuilder outputContent = new StringBuilder();

            using (OracleConnection conn = new OracleConnection())
            {
                conn.ConnectionString = cs;
                conn.Open();
                String commandText = @"select cd_codsys AS base, no_cnt_cmn AS code_commune, cmn01_ncm AS nom_commune FROM MEDOC.CMN01";

                using (OracleCommand cmd = new OracleCommand(commandText))
                {
                    cmd.Connection = conn;

                    using (OracleDataReader dtReader = cmd.ExecuteReader())
                    {

                        while (dtReader != null && dtReader.Read())
                        {
                            for (int i = 0; i < dtReader.FieldCount; i++)
                            {
                                outputContent.Append(dtReader[i]);
                                outputContent.Append(delimiter);
                            }
                            outputContent = outputContent.Replace(delimiter, Environment.NewLine, outputContent.Length - 1, 1);
                            compteur++;
                        }
                    }
                }
            }
            StreamWriter outputStream = new StreamWriter(_file, false);

            //Export
            outputStream.Write(outputContent.ToString());
            outputStream.Close();

            DateTime EndTime = DateTime.Now;
            int tempsInsertion = (EndTime - startTime).Seconds;

            return "Données COMCYC exportées : " + (compteur - 1).ToString() + " lignes récupérées en " + tempsInsertion.ToString() + " seconde(s)";
        }

        protected void InsertDataTable(SqlBulkCopy sqlBulkCopy, SqlConnection sqlConnection, DataTable dataTable)
        {
            sqlBulkCopy.WriteToServer(dataTable);

            dataTable.Rows.Clear();
        }
    }
    
}
