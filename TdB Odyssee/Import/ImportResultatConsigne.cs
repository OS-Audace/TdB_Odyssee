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
    class ImportResultatConsigne
    {
        protected const int _batchSize = 100000;

        public string import(string _file, bool _t0)
        {
            string yourConnectionString = ConfigurationManager.ConnectionStrings["TdB_Odyssee.Properties.Settings.TdbOdysseeConnectionString"].ConnectionString;
            int compteur = 0;

            try
            {
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
                            DestinationTableName = "TDB_RESULTAT_CONSIGNE"
                        };

                        var dataTable = new DataTable("TDB_RESULTAT_CONSIGNE");

                        dataTable.Columns.Add("NUM_ORDRE");
                        dataTable.Columns.Add("ID_CONSIGNE");
                        dataTable.Columns.Add("CODE_BASE");
                        dataTable.Columns.Add("CODE_COMMUNE");
                        dataTable.Columns.Add("BOOL_T0");
                        dataTable.Columns.Add("RESULTAT");

                        // Setup the column mappings, anything ommitted is skipped
                        sqlBulkCopy.ColumnMappings.Add("NUM_ORDRE", "NUM_ORDRE");
                        sqlBulkCopy.ColumnMappings.Add("ID_CONSIGNE", "ID_CONSIGNE");
                        sqlBulkCopy.ColumnMappings.Add("CODE_BASE", "CODE_BASE");
                        sqlBulkCopy.ColumnMappings.Add("CODE_COMMUNE", "CODE_COMMUNE");
                        sqlBulkCopy.ColumnMappings.Add("BOOL_T0", "BOOL_T0");
                        sqlBulkCopy.ColumnMappings.Add("RESULTAT", "RESULTAT");

                        while (!textFieldParser.EndOfData)
                        {
                            var truc = textFieldParser.ReadFields().Take(6).ToArray();

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
                        /*Base_SOURCE retiré de la table Resultat : présent dans CONSIGNE
                        using (var sqlCommand = new SqlCommand(@"UPDATE TDB_COMMUNES SET BASE_SOURCE = 'CYCLADES' WHERE BASE_SOURCE IS NULL", cnx))
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                        */
                    }
                }

                return "OK : " + compteur.ToString() + " lignes intégrée(s)";
            }
            catch (Exception ex)
            {
                return "Erreur : " + ex.Message;
            }
        }

        //public bool EraseT0(int _idConsigne, int 

        protected void InsertDataTable(SqlBulkCopy sqlBulkCopy, SqlConnection sqlConnection, DataTable dataTable)
        {
            sqlBulkCopy.WriteToServer(dataTable);

            dataTable.Rows.Clear();
        }
    }
}