using MySql.Data.MySqlClient;
using SultaniaOil.Models;

namespace SultaniaOil.Data
{
    public class DailyProductionReposetory
    {

        //defining varibale 
        MySqlConnection _connection;

        public DailyProductionReposetory() //constructor  
        {
            //string connStr = @"server=vaibhav\SQLEXPRESS01; database=Eazymr; Integrated Security=true; TrustServerCertificate=true";
            string connStr = "Data Source=localhost; Database=sultaniyaoil; USERID =root; PASSWORD =admin@1234";
            _connection = new MySqlConnection(connStr);
        }


        public List<DailyProductionEntity> GetDailyProduct()
        {
            List<DailyProductionEntity> result = new List<DailyProductionEntity>();
            _connection.Open();

            string query = "SELECT * FROM dailyProduction";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DailyProductionEntity dailyProduction = new DailyProductionEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            ManualDayNight = reader["ManualDayNight"].ToString(),
                            ManualNoOfBags = reader["ManualNoOfBags"].ToString(),
                            ManualPoRed = reader["ManualPoRed"].ToString(),
                            ManualGreen = reader["ManualGreen"].ToString(),
                            ManualRducerCons = reader["ManualRducerCons"].ToString(),
                            ManualNoOfBagsTotal = reader["ManualNoOfBagsTotal"].ToString(),
                            ManualPoRedTotal = reader["ManualPoRedTotal"].ToString(),
                            ManualGreenTotal = reader["ManualGreenTotal"].ToString(),
                            ManualRducerConsTotal = reader["ManualRducerConsTotal"].ToString(),
                            BcsDayNight = reader["BcsDayNight"].ToString(),
                            Bcs1 = reader["Bcs1"].ToString(),
                            Bcs2 = reader["Bcs1"].ToString(),
                            Bcs1Total = reader["BCS1Total"].ToString(),
                            Bcs2Total = reader["BCS2Total"].ToString(),
                            FlexoDayNight = reader["FlexoDayNight"].ToString(),
                            FlexoMeter = reader["FlexoMeter"].ToString(),
                            FlexoInkConsRed = reader["FlexoInkConsRed"].ToString(),
                            FlexoInkConsBlack = reader["FlexoInkConsBlack"].ToString(),
                            FlexoReducerCons = reader["FlexoReducerCons"].ToString(),
                            FlexoBCSMeterTotal = reader["FlexoBCSMeterTotal"].ToString(),
                            FlexoInkConsRedTotal = reader["FlexoInkConsRedTotal"].ToString(),
                            FlexoInkConsBlackTotal = reader["FlexoInkConsBlackTotal"].ToString(),
                            FlexoReducerConsTotal = reader["FlexoReducerConsTotal"].ToString(),
                            LoomWastageShiftA = reader["LoomWastageShiftA"].ToString(),
                            LoomWastageShiftB = reader["LoomWastageShiftB"].ToString(),
                            LoomWastageTotal = reader["LoomWastageTotal"].ToString(),
                            PlantWastageShiftA = reader["PlantWastageShiftA"].ToString(),
                            PlantWastageShiftB = reader["PlantWastageShiftB"].ToString(),
                            PlantWastageTotal = reader["PlantWastageTotal"].ToString(),
                            QuntityWastage = reader["QuntityWastage"].ToString(),
                            CalciumDusting = reader["CalciumDusting"].ToString(),
                            LaminationWastage = reader["LaminationWastage"].ToString(),
                            SlittingWastage = reader["SlittingWastage"].ToString(),
                            TotalWastage = reader["TotalWastage"].ToString(),

                        };

                        result.Add(dailyProduction);
                    }
                }
            }
            _connection.Close();

            return result;
        }





        public bool InsertDailyProduct(DailyProductionEntity dataEntity)
        {
            string query = "INSERT INTO dailyProduction(" +
                           "Date, ManualDayNight, ManualNoOfBags, ManualPoRed, ManualGreen, " +
                           "ManualRducerCons, ManualNoOfBagsTotal, ManualPoRedTotal, ManualGreenTotal, ManualRducerConsTotal, " +
                           "BcsDayNight, Bcs1, Bcs2, BCS1Total, BCS2Total, " +
                           "FlexoDayNight, FlexoMeter, FlexoInkConsRed, FlexoInkConsBlack, FlexoReducerCons, " +
                           "FlexoBCSMeterTotal, FlexoInkConsRedTotal, FlexoInkConsBlackTotal, FlexoReducerConsTotal, " +
                           "LoomWastageShiftA, LoomWastageShiftB, LoomWastageTotal, " +
                           "PlantWastageShiftA, PlantWastageShiftB, PlantWastageTotal, " +
                           "QuntityWastage, CalciumDusting, LaminationWastage, SlittingWastage, TotalWastage) " +
                           "VALUES(@Date, @ManualDayNight, @ManualNoOfBags, @ManualPoRed, @ManualGreen, " +
                           "@ManualRducerCons, @ManualNoOfBagsTotal, @ManualPoRedTotal, @ManualGreenTotal, @ManualRducerConsTotal, " +
                           "@BcsDayNight, @Bcs1, @Bcs2, @BCS1Total, @BCS2Total, " +
                           "@FlexoDayNight, @FlexoMeter, @FlexoInkConsRed, @FlexoInkConsBlack, @FlexoReducerCons, " +
                           "@FlexoBCSMeterTotal, @FlexoInkConsRedTotal, @FlexoInkConsBlackTotal, @FlexoReducerConsTotal, " +
                           "@LoomWastageShiftA, @LoomWastageShiftB, @LoomWastageTotal, " +
                           "@PlantWastageShiftA, @PlantWastageShiftB, @PlantWastageTotal, " +
                           "@QuntityWastage, @CalciumDusting, @LaminationWastage, @SlittingWastage, @TotalWastage)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Date", dataEntity.Date);
                cmd.Parameters.AddWithValue("@ManualDayNight", dataEntity.ManualDayNight);
                cmd.Parameters.AddWithValue("@ManualNoOfBags", dataEntity.ManualNoOfBags);
                cmd.Parameters.AddWithValue("@ManualPoRed", dataEntity.ManualPoRed);
                cmd.Parameters.AddWithValue("@ManualGreen", dataEntity.ManualGreen);
                cmd.Parameters.AddWithValue("@ManualRducerCons", dataEntity.ManualRducerCons);
                cmd.Parameters.AddWithValue("@ManualNoOfBagsTotal", dataEntity.ManualNoOfBagsTotal);
                cmd.Parameters.AddWithValue("@ManualPoRedTotal", dataEntity.ManualPoRedTotal);
                cmd.Parameters.AddWithValue("@ManualGreenTotal", dataEntity.ManualGreenTotal);
                cmd.Parameters.AddWithValue("@ManualRducerConsTotal", dataEntity.ManualRducerConsTotal);

                // ... (previous code)

                cmd.Parameters.AddWithValue("@BcsDayNight", dataEntity.BcsDayNight);
                cmd.Parameters.AddWithValue("@Bcs1", dataEntity.Bcs1);
                cmd.Parameters.AddWithValue("@Bcs2", dataEntity.Bcs2);
                cmd.Parameters.AddWithValue("@BCS1Total", dataEntity.Bcs1Total);
                cmd.Parameters.AddWithValue("@BCS2Total", dataEntity.Bcs2Total);

                cmd.Parameters.AddWithValue("@FlexoDayNight", dataEntity.FlexoDayNight);
                cmd.Parameters.AddWithValue("@FlexoMeter", dataEntity.FlexoMeter);
                cmd.Parameters.AddWithValue("@FlexoInkConsRed", dataEntity.FlexoInkConsRed);
                cmd.Parameters.AddWithValue("@FlexoInkConsBlack", dataEntity.FlexoInkConsBlack);
                cmd.Parameters.AddWithValue("@FlexoReducerCons", dataEntity.FlexoReducerCons);
                cmd.Parameters.AddWithValue("@FlexoBCSMeterTotal", dataEntity.FlexoBCSMeterTotal);
                cmd.Parameters.AddWithValue("@FlexoInkConsRedTotal", dataEntity.FlexoInkConsRedTotal);
                cmd.Parameters.AddWithValue("@FlexoInkConsBlackTotal", dataEntity.FlexoInkConsBlackTotal);
                cmd.Parameters.AddWithValue("@FlexoReducerConsTotal", dataEntity.FlexoReducerConsTotal);

                cmd.Parameters.AddWithValue("@LoomWastageShiftA", dataEntity.LoomWastageShiftA);
                cmd.Parameters.AddWithValue("@LoomWastageShiftB", dataEntity.LoomWastageShiftB);
                cmd.Parameters.AddWithValue("@LoomWastageTotal", dataEntity.LoomWastageTotal);

                cmd.Parameters.AddWithValue("@PlantWastageShiftA", dataEntity.PlantWastageShiftA);
                cmd.Parameters.AddWithValue("@PlantWastageShiftB", dataEntity.PlantWastageShiftB);
                cmd.Parameters.AddWithValue("@PlantWastageTotal", dataEntity.PlantWastageTotal);

                cmd.Parameters.AddWithValue("@QuntityWastage", dataEntity.QuntityWastage);
                cmd.Parameters.AddWithValue("@CalciumDusting", dataEntity.CalciumDusting);
                cmd.Parameters.AddWithValue("@LaminationWastage", dataEntity.LaminationWastage);
                cmd.Parameters.AddWithValue("@SlittingWastage", dataEntity.SlittingWastage);
                cmd.Parameters.AddWithValue("@TotalWastage", dataEntity.TotalWastage);

                

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }





    }
}
