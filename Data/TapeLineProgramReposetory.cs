using MySql.Data.MySqlClient;
using SultaniaOil.Models;
using System.Data.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System;

namespace SultaniaOil.Data
{
    public class TapeLineProgramReposetory
    {
        //defining varibale 
        MySqlConnection _connection;

        public TapeLineProgramReposetory() //constructor  
        {
            //string connStr = @"server=vaibhav\SQLEXPRESS01; database=Eazymr; Integrated Security=true; TrustServerCertificate=true";
            string connStr = "Data Source=localhost; Database=sultaniyaoil; USERID =root; PASSWORD =admin@1234";
            _connection = new MySqlConnection(connStr);
        }





        public bool InsertTapeLinePro(TapeLineProgramEntity granules)  //insert tapeline 
        {
            string query = "INSERT INTO TapeLinePrograme " +
                           "(GranualData, ActualGranual1, ActualGranual2, ActualGranual3, ActualGranual4, " +
                           "ActualGranual5, ActualGranual6, ActualGranual7, ActualGranual8, ActualGranual9, " +
                           "ActualGranual10, ActualGranual11, ActualGranual12, DateColumn, ProgrameNo, " +
                           "JobCode, CreateColor, Bobin, DenierRequired, DenierActual, DenierRemarks, " +
                           "TapeWidthRequired, TapeWidthActual, TapeWidthRemarks, StrenghtRequired, " +
                           "StrenghtActual, StrenghtRemarks, ElongationRequired, ElongationActual, " +
                           "ElongationRemarks, KGSRequired, KGSActual, KGSRemarks) " +
                           "VALUES " +
                           "(@GranualData, @ActualGranual1, @ActualGranual2, @ActualGranual3, @ActualGranual4, " +
                           "@ActualGranual5, @ActualGranual6, @ActualGranual7, @ActualGranual8, @ActualGranual9, " +
                           "@ActualGranual10, @ActualGranual11, @ActualGranual12, @DateColumn, @ProgrameNo, " +
                           "@JobCode, @CreateColor, @Bobin, @DenierRequired, @DenierActual, @DenierRemarks, " +
                           "@TapeWidthRequired, @TapeWidthActual, @TapeWidthRemarks, @StrenghtRequired, " +
                           "@StrenghtActual, @StrenghtRemarks, @ElongationRequired, @ElongationActual, " +
                           "@ElongationRemarks, @KGSRequired, @KGSActual, @KGSRemarks)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                // Set parameter values
                cmd.Parameters.AddWithValue("@GranualData", granules.GranualData);
                cmd.Parameters.AddWithValue("@ActualGranual1", granules.ActualGranual1);
                cmd.Parameters.AddWithValue("@ActualGranual2", granules.ActualGranual2);
                cmd.Parameters.AddWithValue("@ActualGranual3", granules.ActualGranual3);
                cmd.Parameters.AddWithValue("@ActualGranual4", granules.ActualGranual4);
                cmd.Parameters.AddWithValue("@ActualGranual5", granules.ActualGranual5);
                cmd.Parameters.AddWithValue("@ActualGranual6", granules.ActualGranual6);
                cmd.Parameters.AddWithValue("@ActualGranual7", granules.ActualGranual7);
                cmd.Parameters.AddWithValue("@ActualGranual8", granules.ActualGranual8);
                cmd.Parameters.AddWithValue("@ActualGranual9", granules.ActualGranual9);
                cmd.Parameters.AddWithValue("@ActualGranual10", granules.ActualGranual10);
                cmd.Parameters.AddWithValue("@ActualGranual11", granules.ActualGranual11);
                cmd.Parameters.AddWithValue("@ActualGranual12", granules.ActualGranual12);
                cmd.Parameters.AddWithValue("@DateColumn", granules.Date);
                cmd.Parameters.AddWithValue("@ProgrameNo", granules.ProgrameNo);
                cmd.Parameters.AddWithValue("@JobCode", granules.JobCode);
                cmd.Parameters.AddWithValue("@CreateColor", granules.CreateColor);
                cmd.Parameters.AddWithValue("@Bobin", granules.Bobin);
                cmd.Parameters.AddWithValue("@DenierRequired", granules.DenierRequired);
                cmd.Parameters.AddWithValue("@DenierActual", granules.DenierActual);
                cmd.Parameters.AddWithValue("@DenierRemarks", granules.DenierRemarks);
                cmd.Parameters.AddWithValue("@TapeWidthRequired", granules.TapeWidthRequired);
                cmd.Parameters.AddWithValue("@TapeWidthActual", granules.TapeWidthActual);
                cmd.Parameters.AddWithValue("@TapeWidthRemarks", granules.TapeWidthRemarks);
                cmd.Parameters.AddWithValue("@StrenghtRequired", granules.StrenghtRequired);
                cmd.Parameters.AddWithValue("@StrenghtActual", granules.StrenghtActual);
                cmd.Parameters.AddWithValue("@StrenghtRemarks", granules.StrenghtRemarks);
                cmd.Parameters.AddWithValue("@ElongationRequired", granules.ElongationRequired);
                cmd.Parameters.AddWithValue("@ElongationActual", granules.ElongationActual);
                cmd.Parameters.AddWithValue("@ElongationRemarks", granules.ElongationRemarks);
                cmd.Parameters.AddWithValue("@KGSRequired", granules.KGSRequired);
                cmd.Parameters.AddWithValue("@KGSActual", granules.KGSActual);
                cmd.Parameters.AddWithValue("@KGSRemarks", granules.KGSRemarks);

                _connection.Open();

                int i = cmd.ExecuteNonQuery();

                _connection.Close();

                return i >= 1;
            }
        }









        public List<TapeLineProgramEntity> GetTapeLinePro(string? id)// retrive tapline
        {
            string query;

            if (id != null)
            {
                query = "SELECT * FROM TapeLinePrograme WHERE Id = @Id ORDER BY Id DESC";
            }
            else
            {
                query = "SELECT * FROM TapeLinePrograme ORDER BY Id DESC";
            }

            List<TapeLineProgramEntity> granulesEntities = new List<TapeLineProgramEntity>();
            _connection.Open();

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TapeLineProgramEntity result = new TapeLineProgramEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            GranualData = Convert.ToString(reader["GranualData"]),
                            ActualGranual1 = Convert.ToString(reader["ActualGranual1"]),
                            ActualGranual2 = Convert.ToString(reader["ActualGranual2"]),
                            ActualGranual3 = Convert.ToString(reader["ActualGranual3"]),
                            ActualGranual4 = Convert.ToString(reader["ActualGranual4"]),
                            ActualGranual5 = Convert.ToString(reader["ActualGranual5"]),
                            ActualGranual6 = Convert.ToString(reader["ActualGranual6"]),
                            ActualGranual7 = Convert.ToString(reader["ActualGranual7"]),
                            ActualGranual8 = Convert.ToString(reader["ActualGranual8"]),
                            ActualGranual9 = Convert.ToString(reader["ActualGranual9"]),
                            ActualGranual10 = Convert.ToString(reader["ActualGranual10"]),
                            ActualGranual11 = Convert.ToString(reader["ActualGranual11"]),
                            ActualGranual12 = Convert.ToString(reader["ActualGranual12"]),
                            Date = Convert.ToDateTime(reader["DateColumn"]),
                            ProgrameNo = Convert.ToString(reader["ProgrameNo"]),
                            JobCode = Convert.ToString(reader["JobCode"]),
                            CreateColor = Convert.ToString(reader["CreateColor"]),
                            DenierRequired = Convert.ToString(reader["DenierRequired"]),
                            DenierActual = Convert.ToString(reader["DenierActual"]),
                            DenierRemarks = Convert.ToString(reader["DenierRemarks"]),
                            TapeWidthRequired = Convert.ToString(reader["TapeWidthRequired"]),
                            TapeWidthActual = Convert.ToString(reader["TapeWidthActual"]),
                            TapeWidthRemarks = Convert.ToString(reader["TapeWidthRemarks"]),
                            StrenghtRequired = Convert.ToString(reader["StrenghtRequired"]),
                            StrenghtActual = Convert.ToString(reader["StrenghtActual"]),
                            StrenghtRemarks = Convert.ToString(reader["StrenghtRemarks"]),
                            ElongationRequired = Convert.ToString(reader["ElongationRequired"]),
                            ElongationActual = Convert.ToString(reader["ElongationActual"]),
                            ElongationRemarks = Convert.ToString(reader["ElongationRemarks"]),
                            KGSRequired = Convert.ToString(reader["KGSRequired"]),
                            KGSActual = Convert.ToString(reader["KGSActual"]),
                            KGSRemarks = Convert.ToString(reader["KGSRemarks"]),
                            Bobin = Convert.ToString(reader["Bobin"]),
                        };

                        granulesEntities.Add(result);
                    }
                }
            }

            _connection.Close();

            return granulesEntities;
        }




        public bool DaleteTapeLine(int Id) //Delete tape line
        {
            string query = "DELETE FROM TapeLinePrograme WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", Id);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();
                if (i >= 1) { return true; }
                else { return false; }
            }
        }


    }
}
