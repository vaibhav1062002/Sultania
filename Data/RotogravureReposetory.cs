using MySql.Data.MySqlClient;
using SultaniaOil.Models;
using System.Data.Common;

namespace SultaniaOil.Data
{
    public class RotogravureReposetory
    {
        //defining varibale 
        MySqlConnection _connection;

        public RotogravureReposetory() //constructor  
        {
            //string connStr = @"server=vaibhav\SQLEXPRESS01; database=Eazymr; Integrated Security=true; TrustServerCertificate=true";
            string connStr = "Data Source=localhost; Database=sultaniyaoil; USERID =root; PASSWORD =admin@1234";
            _connection = new MySqlConnection(connStr);
        }


        public List<RotogravureEntity> GetRotogravure() // view bagmaster data 
        {
            List<RotogravureEntity> result = new List<RotogravureEntity>();
            _connection.Open();

            string query = "SELECT * FROM rotogravure";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RotogravureEntity roto = new RotogravureEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            JobName = reader["JobName"].ToString(),
                            Date = Convert.ToDateTime(reader["Date"]),
                            Shift = reader["Shift"].ToString(),
                            ProNumber = reader["ProNumber"].ToString(),
                            NoOfCylender = reader["NoOfCylender"].ToString(),
                            MeterToBePrinted = reader["MeterToBePrinted"].ToString(),
                            Color = reader["Color"].ToString(),
                            PlainBoppRollNo = reader["PlainBoppRollNo"].ToString(),
                            PlainMeter = reader["PlainMeter"].ToString(),
                            PlainNetWeight = reader["PlainNetWeight"].ToString(),
                            PlainAvgWeight = reader["PlainAvgWeight"].ToString(),
                            PrintedBoppRollNo = reader["PrintedBoppRollNo"].ToString(),
                            PrintedMeter = reader["PrintedMeter"].ToString(),
                            PrintedNetWeight = reader["PrintedNetWeight"].ToString(),
                            PrintedAvgWeight = reader["PrintedAvgWeight"].ToString(),
                            SlittedBoppRollNo = reader["SlittedBoppRollNo"].ToString(),
                            SlittedMeter = reader["SlittedMeter"].ToString(),
                            SlittedNetWeight = reader["SlittedNetWeight"].ToString(),
                            SlittedAvgWeight = reader["SlittedAvgWeight"].ToString(),
                            FreshInkColor = reader["FreshInkColor"].ToString(),
                            FreshIssued = reader["FreshIssued"].ToString(),
                            FreshReturned = reader["FreshReturned"].ToString(),
                            FreshActConsuption = reader["FreshActConsuption"].ToString(),
                            MixInkColor = reader["MixInkColor"].ToString(),
                            MixIssued = reader["MixIssued"].ToString(),
                            MixReturned = reader["MixReturned"].ToString(),
                            MixActConsuption = reader["MixActConsuption"].ToString(),
                            ChemicalParticulars = reader["ChemicalParticulars"].ToString(),
                            ChemicalIssued = reader["ChemicalIssued"].ToString(),
                            ChemicalReturned = reader["ChemicalReturned"].ToString(),
                            ChemicalActConsuption = reader["ChemicalActConsuption"].ToString(),
                        };
                        result.Add(roto);


                    }
                }
            }
            _connection.Close();

            return result;

        }




        public bool InsertRotogravure(RotogravureEntity dataEntity)
        {
            string query = "INSERT INTO rotogravure(" +
                           "JobName, Date, Shift, ProNumber, NoOfCylender, MeterToBePrinted, Color, " +
                           "PlainBoppRollNo, PlainMeter, PlainNetWeight, PlainAvgWeight, " +
                           "PrintedBoppRollNo, PrintedMeter, PrintedNetWeight, PrintedAvgWeight, " +
                           "SlittedBoppRollNo, SlittedMeter, SlittedNetWeight, SlittedAvgWeight, " +
                           "FreshInkColor, FreshIssued, FreshReturned, FreshActConsuption, " +
                           "MixInkColor, MixIssued, MixReturned, MixActConsuption, " +
                           "ChemicalParticulars, ChemicalIssued, ChemicalReturned, ChemicalActConsuption) " +
                           "VALUES(@JobName, @Date, @Shift, @ProNumber, @NoOfCylender, @MeterToBePrinted, @Color, " +
                           "@PlainBoppRollNo, @PlainMeter, @PlainNetWeight, @PlainAvgWeight, " +
                           "@PrintedBoppRollNo, @PrintedMeter, @PrintedNetWeight, @PrintedAvgWeight, " +
                           "@SlittedBoppRollNo, @SlittedMeter, @SlittedNetWeight, @SlittedAvgWeight, " +
                           "@FreshInkColor, @FreshIssued, @FreshReturned, @FreshActConsuption, " +
                           "@MixInkColor, @MixIssued, @MixReturned, @MixActConsuption, " +
                           "@ChemicalParticulars, @ChemicalIssued, @ChemicalReturned, @ChemicalActConsuption)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@JobName", dataEntity.JobName);
                cmd.Parameters.AddWithValue("@Date", dataEntity.Date);
                cmd.Parameters.AddWithValue("@Shift", dataEntity.Shift);
                cmd.Parameters.AddWithValue("@ProNumber", dataEntity.ProNumber);
                cmd.Parameters.AddWithValue("@NoOfCylender", dataEntity.NoOfCylender);
                cmd.Parameters.AddWithValue("@MeterToBePrinted", dataEntity.MeterToBePrinted);
                cmd.Parameters.AddWithValue("@Color", dataEntity.Color);

                cmd.Parameters.AddWithValue("@PlainBoppRollNo", dataEntity.PlainBoppRollNo);
                cmd.Parameters.AddWithValue("@PlainMeter", dataEntity.PlainMeter);
                cmd.Parameters.AddWithValue("@PlainNetWeight", dataEntity.PlainNetWeight);
                cmd.Parameters.AddWithValue("@PlainAvgWeight", dataEntity.PlainAvgWeight);

                cmd.Parameters.AddWithValue("@PrintedBoppRollNo", dataEntity.PrintedBoppRollNo);
                cmd.Parameters.AddWithValue("@PrintedMeter", dataEntity.PrintedMeter);
                cmd.Parameters.AddWithValue("@PrintedNetWeight", dataEntity.PrintedNetWeight);
                cmd.Parameters.AddWithValue("@PrintedAvgWeight", dataEntity.PrintedAvgWeight);

                cmd.Parameters.AddWithValue("@SlittedBoppRollNo", dataEntity.SlittedBoppRollNo);
                cmd.Parameters.AddWithValue("@SlittedMeter", dataEntity.SlittedMeter);
                cmd.Parameters.AddWithValue("@SlittedNetWeight", dataEntity.SlittedNetWeight);
                cmd.Parameters.AddWithValue("@SlittedAvgWeight", dataEntity.SlittedAvgWeight);

                cmd.Parameters.AddWithValue("@FreshInkColor", dataEntity.FreshInkColor);
                cmd.Parameters.AddWithValue("@FreshIssued", dataEntity.FreshIssued);
                cmd.Parameters.AddWithValue("@FreshReturned", dataEntity.FreshReturned);
                cmd.Parameters.AddWithValue("@FreshActConsuption", dataEntity.FreshActConsuption);

                cmd.Parameters.AddWithValue("@MixInkColor", dataEntity.MixInkColor);
                cmd.Parameters.AddWithValue("@MixIssued", dataEntity.MixIssued);
                cmd.Parameters.AddWithValue("@MixReturned", dataEntity.MixReturned);
                cmd.Parameters.AddWithValue("@MixActConsuption", dataEntity.MixActConsuption);

                cmd.Parameters.AddWithValue("@ChemicalParticulars", dataEntity.ChemicalParticulars);
                cmd.Parameters.AddWithValue("@ChemicalIssued", dataEntity.ChemicalIssued);
                cmd.Parameters.AddWithValue("@ChemicalReturned", dataEntity.ChemicalReturned);
                cmd.Parameters.AddWithValue("@ChemicalActConsuption", dataEntity.ChemicalActConsuption);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }
    }

}

