using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TdB_Odyssee.Import
{
    class ImportComcycFiles
    {
        private StringBuilder myInsertResult;
        protected const int _batchSize = 100000;

        public ImportComcycFiles()
        {
            this.myInsertResult = new StringBuilder();
        }


        public string importComcycFiles(string _file)
        {
            myInsertResult.AppendLine("Import COMCYC :");
            myInsertResult.AppendLine(this.import(_file));
            myInsertResult.AppendLine("");

            return myInsertResult.ToString();
        }

        private string import(string _file)
        {
            string yourConnectionString = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.TdbOdysseeConnectionString"].ConnectionString;
            int compteur = 0;
            DateTime startTime = DateTime.Now;

            using (var textFieldParser = new TextFieldParser(_file, Encoding.UTF8))
            {
                textFieldParser.TextFieldType = FieldType.Delimited;
                textFieldParser.Delimiters = new[] { "|" };
                textFieldParser.HasFieldsEnclosedInQuotes = true;

                using (var cnx = new SqlConnection(yourConnectionString))
                {
                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();

                    // Create the bulk copy object
                    var sqlBulkCopy = new SqlBulkCopy(cnx)
                    {
                        DestinationTableName = "TDB_COMMUNES"
                    };

                    var dataTable = new DataTable("TDB_COMMUNES");

                    dataTable.Columns.Add("NUM_BASE");
                    dataTable.Columns.Add("CODE_COMMUNE");
                    dataTable.Columns.Add("NOM_COMMUNE");

                    // Setup the column mappings, anything ommitted is skipped
                    sqlBulkCopy.ColumnMappings.Add("NUM_BASE", "NUM_BASE");
                    sqlBulkCopy.ColumnMappings.Add("CODE_COMMUNE", "CODE_COMMUNE");
                    sqlBulkCopy.ColumnMappings.Add("NOM_COMMUNE", "NOM_COMMUNE");

                    while (!textFieldParser.EndOfData)
                    {
                        var truc = textFieldParser.ReadFields().Take(3).ToArray();

                        //on vérifie si c'est la ligne d'entete, et si oui on la saute
                        if (truc[0] != "N° Client LDE")
                            dataTable.Rows.Add(truc);
                        compteur++;

                        if (compteur % _batchSize == 0)
                        {
                            InsertDataTable(sqlBulkCopy, cnx, dataTable);
                            dataTable.Clear();
                        }

                    }
                    InsertDataTable(sqlBulkCopy, cnx, dataTable);

                    // MISE A JOUR DE LA SOURCE
                    using (var sqlCommand = new SqlCommand(@"UPDATE TDB_COMMUNES SET BASE_SOURCE = 'CYCLADES' WHERE BASE_SOURCE IS NULL", cnx))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    // Suppression des doublons
                    using (var sqlCommand = new SqlCommand(@"DELETE FROM [TdbOdyssee].[dbo].[TDB_COMMUNES] 
                                                            WHERE [BASE_SOURCE] = 'CYCLADES' AND
                                                            [ID_COMMUNE] IN 
                                                            (
                                                            SELECT MAX([ID_COMMUNE]) AS [ID_COMMUNE]
                                                            FROM [TdbOdyssee].[dbo].[TDB_COMMUNES]
                                                            WHERE  [BASE_SOURCE] = 'CYCLADES'
                                                            GROUP BY [NUM_BASE],[CODE_COMMUNE]
                                                            HAVING COUNT(*) > 1
                                                            )", cnx))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }

            DateTime EndTime = DateTime.Now;
            int tempsInsertion = (EndTime - startTime).Seconds;

            return "Données COMCYC importées : " + (compteur - 1).ToString() + " lignes insérées en " + tempsInsertion.ToString() + " seconde(s)";
        }

        protected void InsertDataTable(SqlBulkCopy sqlBulkCopy, SqlConnection sqlConnection, DataTable dataTable)
        {
            sqlBulkCopy.WriteToServer(dataTable);

            dataTable.Rows.Clear();
        }
    }
}
