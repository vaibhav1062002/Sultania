using MySql.Data.MySqlClient;
using SultaniaOil.Models;
using System.Collections.Generic;

namespace SultaniaOil.Data
{
    public class RollDraftingAndStockWastegeReposetory
    {

        //defining varibale 
        MySqlConnection _connection;

        public RollDraftingAndStockWastegeReposetory() //constructor  
        {
            //string connStr = @"server=vaibhav\SQLEXPRESS01; database=Eazymr; Integrated Security=true; TrustServerCertificate=true";
            string connStr = "Data Source=localhost; Database=sultaniyaoil; USERID =root; PASSWORD =admin@1234";
            _connection = new MySqlConnection(connStr);
        }




        public List<UnusedRollStockEntity> GetUnusedRollstock() //view data from unused stock 
        {
            List<UnusedRollStockEntity> result = new List<UnusedRollStockEntity>();
            _connection.Open();

            string query = "SELECT * FROM unusedrollstock";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UnusedRollStockEntity entity = new UnusedRollStockEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            SizeAndDenier = reader["SizeAndDenier"].ToString(),
                            Meter = Convert.ToInt32(reader["Meter"]),
                            Weight = Convert.ToInt32(reader["Weight"]),
                            Average = Convert.ToInt32(reader["Average"]),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            NoOfRolls = Convert.ToInt32(reader["NoOfRolls"]),
                            Date = Convert.ToDateTime(reader["Date"])
                        };

                        result.Add(entity);
                    }
                }
            }
            _connection.Close();

            return result;
        }




        public bool InsertUnusedRollstock(UnusedRollStockEntity dataEntity) //insert data in unused roll stock 
        {
            string query = "INSERT INTO unusedrollstock (SizeAndDenier, Meter, Weight, Average, Quantity, NoOfRolls, Date) VALUES (@SizeAndDenier, @Meter, @Weight, @Average, @Quantity, @NoOfRolls, @Date)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@SizeAndDenier", dataEntity.SizeAndDenier);
                cmd.Parameters.AddWithValue("@Meter", dataEntity.Meter);
                cmd.Parameters.AddWithValue("@Weight", dataEntity.Weight);
                cmd.Parameters.AddWithValue("@Average", dataEntity.Average);
                cmd.Parameters.AddWithValue("@Quantity", dataEntity.Quantity);
                cmd.Parameters.AddWithValue("@NoOfRolls", dataEntity.NoOfRolls);
                cmd.Parameters.AddWithValue("@Date", dataEntity.Date);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }




        // 19 inche to 30 inches start 


        public List<Inches19Entity> RetrieveInches19() // retrive 19 inches data 
        {
            List<Inches19Entity> result = new List<Inches19Entity>();
            _connection.Open();

            string query = "SELECT * FROM inches19";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Inches19Entity entity = new Inches19Entity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            RollNumber = reader["RollNumber"].ToString(),
                            Size = reader["Size"].ToString(),
                            WidthInMM = reader["WidthInMM"].ToString(),
                            LoomNumber = reader["LoomNumber"].ToString(),
                            MTR = reader["MTR"].ToString(),
                            GWeight = reader["GWeight"].ToString(),
                            NetWeight = reader["NetWeight"].ToString(),
                            Average = reader["Average"].ToString(),
                            Dennier = reader["Dennier"].ToString(),
                            Date2 = Convert.ToDateTime(reader["Date2"]),
                            Sales = reader["Sales"].ToString(),
                            IsuueOfLamination = reader["IsuueOfLamination"].ToString(),
                            IssueForBCS = reader["IssueForBCS"].ToString(),
                            BalanceWeight = reader["BalanceWeight"].ToString()
                        };

                        result.Add(entity);
                    }
                }
            }
            _connection.Close();

            return result;
        }



        public bool InsertInches19(Inches19Entity dataEntity)  // insert data in 19 inches 
        {
            string query = "INSERT INTO inches19 (Date, RollNumber, Size, WidthInMM, LoomNumber, MTR, GWeight, NetWeight, Average, Dennier, Date2, Sales, IsuueOfLamination, IssueForBCS, BalanceWeight) " +
                           "VALUES (@Date, @RollNumber, @Size, @WidthInMM, @LoomNumber, @MTR, @GWeight, @NetWeight, @Average, @Dennier, @Date2, @Sales, @IsuueOfLamination, @IssueForBCS, @BalanceWeight)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Date", dataEntity.Date);
                cmd.Parameters.AddWithValue("@RollNumber", dataEntity.RollNumber);
                cmd.Parameters.AddWithValue("@Size", dataEntity.Size);
                cmd.Parameters.AddWithValue("@WidthInMM", dataEntity.WidthInMM);
                cmd.Parameters.AddWithValue("@LoomNumber", dataEntity.LoomNumber);
                cmd.Parameters.AddWithValue("@MTR", dataEntity.MTR);
                cmd.Parameters.AddWithValue("@GWeight", dataEntity.GWeight);
                cmd.Parameters.AddWithValue("@NetWeight", dataEntity.NetWeight);
                cmd.Parameters.AddWithValue("@Average", dataEntity.Average);
                cmd.Parameters.AddWithValue("@Dennier", dataEntity.Dennier);
                cmd.Parameters.AddWithValue("@Date2", dataEntity.Date2);
                cmd.Parameters.AddWithValue("@Sales", dataEntity.Sales);
                cmd.Parameters.AddWithValue("@IsuueOfLamination", dataEntity.IsuueOfLamination);
                cmd.Parameters.AddWithValue("@IssueForBCS", dataEntity.IssueForBCS);
                cmd.Parameters.AddWithValue("@BalanceWeight", dataEntity.BalanceWeight);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }





        public List<Inches26Entity> RetrieveInches26() //retrive 26 inches data
        {
            List<Inches26Entity> result = new List<Inches26Entity>();
            _connection.Open();

            string query = "SELECT * FROM inches26";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Inches26Entity entity = new Inches26Entity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            RollNumber = reader["RollNumber"].ToString(),
                            Size = reader["Size"].ToString(),
                            WidthInMM = reader["WidthInMM"].ToString(),
                            LoomNumber = reader["LoomNumber"].ToString(),
                            MTRS = reader["MTRS"].ToString(),
                            GWeight = reader["GWeight"].ToString(),
                            CWeight = reader["CWeight"].ToString(),
                            NWeight = reader["NWeight"].ToString(),
                            Average = reader["Average"].ToString(),
                            Dennier = reader["Dennier"].ToString(),
                            Date2 = Convert.ToDateTime(reader["Date2"]),
                            IssueOfLamination = reader["IssueOfLamination"].ToString(),
                            IssueForBCSMeter = reader["IssueForBCSMeter"].ToString(),
                            IssueForBCSWeight = reader["IssueForBCSWeight"].ToString(),
                            BalanceWeightMeter = reader["BalanceWeightMeter"].ToString(),
                            BalanceWeightWeight = reader["BalanceWeightWeight"].ToString()
                        };

                        result.Add(entity);
                    }
                }
            }
            _connection.Close();

            return result;
        }





        public bool InsertInches26(Inches26Entity dataEntity) // insert 26 inches data
        {
            string query = "INSERT INTO inches26 (Date, RollNumber, Size, WidthInMM, LoomNumber, MTRS, GWeight, CWeight, NWeight, Average, Dennier, Date2, IssueOfLamination, IssueForBCSMeter, IssueForBCSWeight, BalanceWeightMeter, BalanceWeightWeight) " +
                           "VALUES (@Date, @RollNumber, @Size, @WidthInMM, @LoomNumber, @MTRS, @GWeight, @CWeight, @NWeight, @Average, @Dennier, @Date2, @IssueOfLamination, @IssueForBCSMeter, @IssueForBCSWeight, @BalanceWeightMeter, @BalanceWeightWeight)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Date", dataEntity.Date);
                cmd.Parameters.AddWithValue("@RollNumber", dataEntity.RollNumber);
                cmd.Parameters.AddWithValue("@Size", dataEntity.Size);
                cmd.Parameters.AddWithValue("@WidthInMM", dataEntity.WidthInMM);
                cmd.Parameters.AddWithValue("@LoomNumber", dataEntity.LoomNumber);
                cmd.Parameters.AddWithValue("@MTRS", dataEntity.MTRS);
                cmd.Parameters.AddWithValue("@GWeight", dataEntity.GWeight);
                cmd.Parameters.AddWithValue("@CWeight", dataEntity.CWeight);
                cmd.Parameters.AddWithValue("@NWeight", dataEntity.NWeight);
                cmd.Parameters.AddWithValue("@Average", dataEntity.Average);
                cmd.Parameters.AddWithValue("@Dennier", dataEntity.Dennier);
                cmd.Parameters.AddWithValue("@Date2", dataEntity.Date2);
                cmd.Parameters.AddWithValue("@IssueOfLamination", dataEntity.IssueOfLamination);
                cmd.Parameters.AddWithValue("@IssueForBCSMeter", dataEntity.IssueForBCSMeter);
                cmd.Parameters.AddWithValue("@IssueForBCSWeight", dataEntity.IssueForBCSWeight);
                cmd.Parameters.AddWithValue("@BalanceWeightMeter", dataEntity.BalanceWeightMeter);
                cmd.Parameters.AddWithValue("@BalanceWeightWeight", dataEntity.BalanceWeightWeight);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }




        public List<Inches28Entity> RetrieveInches28()   // retrive 28 inches data
        {
            List<Inches28Entity> result = new List<Inches28Entity>();
            _connection.Open();

            string query = "SELECT * FROM inches28";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Inches28Entity entity = new Inches28Entity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            RollNumber = reader["RollNumber"].ToString(),
                            Size = reader["Size"].ToString(),
                            WidthInMM = reader["WidthInMM"].ToString(),
                            LoomNumber = reader["LoomNumber"].ToString(),
                            MTRS = reader["MTRS"].ToString(),
                            GWeight = reader["GWeight"].ToString(),
                            CWeight = reader["CWeight"].ToString(),
                            NWeight = reader["NWeight"].ToString(),
                            Average = reader["Average"].ToString(),
                            Remark = reader["Remark"].ToString(),
                            Date2 = Convert.ToDateTime(reader["Date2"]),
                            Sales = reader["Sales"].ToString(),
                            IssueOfReasion = reader["IssueOfReasion"].ToString(),
                            MTRSForBCS = reader["MTRSForBCS"].ToString(),
                            NetWeightForBCS = reader["NetWeightForBCS"].ToString(),
                            MTRSForBalanceWeight = reader["MTRSForBalanceWeight"].ToString(),
                            NetWeightForBalanceWeight = reader["NetWeightForBalanceWeight"].ToString()
                        };

                        result.Add(entity);
                    }
                }
            }
            _connection.Close();

            return result;
        }








        public bool InsertInches28(Inches28Entity dataEntity)  // retrive 28 inches data
        {
            string query = "INSERT INTO inches28 (Date, RollNumber, Size, WidthInMM, LoomNumber, MTRS, GWeight, CWeight, NWeight, Average, Remark, Date2, IssueOfReasion, MTRSForBCS, NetWeightForBCS, MTRSForBalanceWeight, NetWeightForBalanceWeight) " +
                           "VALUES (@Date, @RollNumber, @Size, @WidthInMM, @LoomNumber, @MTRS, @GWeight, @CWeight, @NWeight, @Average, @Remark, @Date2, @Sales, @IssueOfReasion, @MTRSForBCS, @NetWeightForBCS, @MTRSForBalanceWeight, @NetWeightForBalanceWeight)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Date", dataEntity.Date);
                cmd.Parameters.AddWithValue("@RollNumber", dataEntity.RollNumber);
                cmd.Parameters.AddWithValue("@Size", dataEntity.Size);
                cmd.Parameters.AddWithValue("@WidthInMM", dataEntity.WidthInMM);
                cmd.Parameters.AddWithValue("@LoomNumber", dataEntity.LoomNumber);
                cmd.Parameters.AddWithValue("@MTRS", dataEntity.MTRS);
                cmd.Parameters.AddWithValue("@GWeight", dataEntity.GWeight);
                cmd.Parameters.AddWithValue("@CWeight", dataEntity.CWeight);
                cmd.Parameters.AddWithValue("@NWeight", dataEntity.NWeight);
                cmd.Parameters.AddWithValue("@Average", dataEntity.Average);
                cmd.Parameters.AddWithValue("@Remark", dataEntity.Remark);
                cmd.Parameters.AddWithValue("@Date2", dataEntity.Date2);
                cmd.Parameters.AddWithValue("@Sales", dataEntity.Sales);
                cmd.Parameters.AddWithValue("@IssueOfReasion", dataEntity.IssueOfReasion);
                cmd.Parameters.AddWithValue("@MTRSForBCS", dataEntity.MTRSForBCS);
                cmd.Parameters.AddWithValue("@NetWeightForBCS", dataEntity.NetWeightForBCS);
                cmd.Parameters.AddWithValue("@MTRSForBalanceWeight", dataEntity.MTRSForBalanceWeight);
                cmd.Parameters.AddWithValue("@NetWeightForBalanceWeight", dataEntity.NetWeightForBalanceWeight);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }







        public List<Inches30Entity> RetrieveInches30()
{
    List<Inches30Entity> result = new List<Inches30Entity>();
    _connection.Open();

    string query = "SELECT * FROM inches30"; // Replace YourTableName with your actual table name

    using (MySqlCommand cmd = new MySqlCommand(query, _connection))
    {
        using (MySqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                 Inches30Entity entity = new Inches30Entity
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Date = Convert.ToDateTime(reader["Date"]),
                    RollNumber = reader["RollNumber"].ToString(),
                    Size = reader["Size"].ToString(),
                    WidthInMM = reader["WidthInMM"].ToString(),
                    LoomNumber = reader["LoomNumber"].ToString(),
                    MTRS = reader["MTRS"].ToString(),
                    GWeight = reader["GWeight"].ToString(),
                    CWeight = reader["CWeight"].ToString(),
                    NWeight = reader["NWeight"].ToString(),
                    Average = reader["Average"].ToString(),
                    Remark = reader["Remark"].ToString(),
                    Date2 = Convert.ToDateTime(reader["Date2"]),
                    IssueOfReasion = reader["IssueOfReasion"].ToString(),
                    IssueForBCSMTRS = reader["IssueForBCSMTRS"].ToString(),
                    IssueForNetWeight = reader["IssueForNetWeight"].ToString(),
                    BalanceWeightMTRS = reader["BalanceWeightMTRS"].ToString(),
                    BalanceWeightNetWeight = reader["BalanceWeightNetWeight"].ToString()
                };

                result.Add(entity);
            }
        }
    }
    _connection.Close();

    return result;
}







  public bool InsertInches30(Inches30Entity dataEntity)
  {
    string query = "INSERT INTO inches30 (Date, RollNumber, Size, WidthInMM, LoomNumber, MTRS, GWeight, CWeight, NWeight, Average, Remark, Date2, IssueOfReasion, IssueForBCSMTRS, IssueForNetWeight, BalanceWeightMTRS, BalanceWeightNetWeight) " +
                   "VALUES (@Date, @RollNumber, @Size, @WidthInMM, @LoomNumber, @MTRS, @GWeight, @CWeight, @NWeight, @Average, @Remark, @Date2, @IssueOfReasion, @IssueForBCSMTRS, @IssueForNetWeight, @BalanceWeightMTRS, @BalanceWeightNetWeight)";

    using (MySqlCommand cmd = new MySqlCommand(query, _connection))
    {
        cmd.Parameters.AddWithValue("@Date", dataEntity.Date);
        cmd.Parameters.AddWithValue("@RollNumber", dataEntity.RollNumber);
        cmd.Parameters.AddWithValue("@Size", dataEntity.Size);
        cmd.Parameters.AddWithValue("@WidthInMM", dataEntity.WidthInMM);
        cmd.Parameters.AddWithValue("@LoomNumber", dataEntity.LoomNumber);
        cmd.Parameters.AddWithValue("@MTRS", dataEntity.MTRS);
        cmd.Parameters.AddWithValue("@GWeight", dataEntity.GWeight);
        cmd.Parameters.AddWithValue("@CWeight", dataEntity.CWeight);
        cmd.Parameters.AddWithValue("@NWeight", dataEntity.NWeight);
        cmd.Parameters.AddWithValue("@Average", dataEntity.Average);
        cmd.Parameters.AddWithValue("@Remark", dataEntity.Remark);
        cmd.Parameters.AddWithValue("@Date2", dataEntity.Date2);
        cmd.Parameters.AddWithValue("@IssueOfReasion", dataEntity.IssueOfReasion);
        cmd.Parameters.AddWithValue("@IssueForBCSMTRS", dataEntity.IssueForBCSMTRS);
        cmd.Parameters.AddWithValue("@IssueForNetWeight", dataEntity.IssueForNetWeight);
        cmd.Parameters.AddWithValue("@BalanceWeightMTRS", dataEntity.BalanceWeightMTRS);
        cmd.Parameters.AddWithValue("@BalanceWeightNetWeight", dataEntity.BalanceWeightNetWeight);

        _connection.Open();
        int i = cmd.ExecuteNonQuery();
        _connection.Close();

        return i >= 1;
    }
}









        public List<Flatesheet60Entity> RetrieveFlatesheet60()        // retrive flate
        {
            List<Flatesheet60Entity> result = new List<Flatesheet60Entity>();
            _connection.Open();

            string query = "SELECT * FROM flatsheet60"; 

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Flatesheet60Entity entity = new Flatesheet60Entity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            RollNumber = reader["RollNumber"].ToString(),
                            Size = reader["Size"].ToString(),
                            WidthInMM = reader["WidthInMM"].ToString(),
                            LoomNumber = reader["LoomNumber"].ToString(),
                            MTRS = reader["MTRS1"].ToString(),
                            GWeight = reader["GWeight"].ToString(),
                            CWeight = reader["CWeight"].ToString(),
                            NWeight = reader["NWeight"].ToString(),
                            Average = reader["Average"].ToString(),
                            Date2 = Convert.ToDateTime(reader["Date2"]),
                            Sales = reader["Sales"].ToString(),
                            IssueOfLamination = reader["IssueOfLamination"].ToString(),
                            IssueMTRS = reader["MTRS2"].ToString(),
                            IssueNetWeight = reader["NetWeight1"].ToString(),
                            Total1 = reader["Total1"].ToString(),
                            Total2 = reader["Total2"].ToString(),
                            BalanceMTRS = reader["MTRS3"].ToString(),
                            BalanceNetWeight = reader["NetWeight2"].ToString()
                        };

                        result.Add(entity);
                    }
                }
            }
            _connection.Close();

            return result;
        }




        public bool InsertFlatesheet60(Flatesheet60Entity dataEntity) // insert flate sheet 
        {
            string query = "INSERT INTO flatsheet60 (Date, RollNumber, Size, WidthInMM, LoomNumber, MTRS1, GWeight, CWeight, NWeight, Average, Date2, Sales, IssueOfLamination, MTRS2, NetWeight1, Total1, Total2, MTRS3, NetWeight2) " +
                           "VALUES (@Date, @RollNumber, @Size, @WidthInMM, @LoomNumber, @MTRS1, @GWeight, @CWeight, @NWeight, @Average, @Date2, @Sales, @IssueOfLamination, @MTRS2, @NetWeight1, @Total1, @Total2, @MTRS3, @NetWeight2)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Date", dataEntity.Date);
                cmd.Parameters.AddWithValue("@RollNumber", dataEntity.RollNumber);
                cmd.Parameters.AddWithValue("@Size", dataEntity.Size);
                cmd.Parameters.AddWithValue("@WidthInMM", dataEntity.WidthInMM);
                cmd.Parameters.AddWithValue("@LoomNumber", dataEntity.LoomNumber);
                cmd.Parameters.AddWithValue("@MTRS1", dataEntity.MTRS);
                cmd.Parameters.AddWithValue("@GWeight", dataEntity.GWeight);
                cmd.Parameters.AddWithValue("@CWeight", dataEntity.CWeight);
                cmd.Parameters.AddWithValue("@NWeight", dataEntity.NWeight);
                cmd.Parameters.AddWithValue("@Average", dataEntity.Average);
                cmd.Parameters.AddWithValue("@Date2", dataEntity.Date2);
                cmd.Parameters.AddWithValue("@Sales", dataEntity.Sales);
                cmd.Parameters.AddWithValue("@IssueOfLamination", dataEntity.IssueOfLamination);
                cmd.Parameters.AddWithValue("@MTRS2", dataEntity.IssueMTRS);
                cmd.Parameters.AddWithValue("@NetWeight1", dataEntity.BalanceNetWeight);
                cmd.Parameters.AddWithValue("@Total1", dataEntity.Total1);
                cmd.Parameters.AddWithValue("@Total2", dataEntity.Total2);
                cmd.Parameters.AddWithValue("@MTRS3", dataEntity.BalanceMTRS);
                cmd.Parameters.AddWithValue("@NetWeight2", dataEntity.BalanceNetWeight);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }







        public List<CM45Entity> RetrieveCM45()        // retrive CM45
        {
            List<CM45Entity> result = new List<CM45Entity>();
            _connection.Open();

            string query = "SELECT * FROM cm45";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CM45Entity entity = new CM45Entity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            RollNumber = reader["RollNumber"].ToString(),
                            Size = reader["Size"].ToString(),
                            WidthInMM = reader["WidthInMM"].ToString(),
                            LoomNumber = reader["LoomNumber"].ToString(),
                            MTRS = reader["MTRS1"].ToString(),
                            GWeight = reader["GWeight"].ToString(),
                            CWeight = reader["CWeight"].ToString(),
                            NWeight = reader["NWeight"].ToString(),
                            Average = reader["Average"].ToString(),
                            Date2 = Convert.ToDateTime(reader["Date2"]),
                            Sales = reader["Sales"].ToString(),
                            IssueOfLamination = reader["IssueOfLamination"].ToString(),
                            IssueMTRS = reader["MTRS2"].ToString(),
                            IssueNetWeight = reader["NetWeight1"].ToString(),
                            Total1 = reader["Total1"].ToString(),
                            Total2 = reader["Total2"].ToString(),
                            BalanceMTRS = reader["MTRS3"].ToString(),
                            BalanceNetWeight = reader["NetWeight2"].ToString()
                        };

                        result.Add(entity);
                    }
                }
            }
            _connection.Close();

            return result;
        }




        public bool InsertCM45(CM45Entity dataEntity)   // insert CM45
        {
            string query = "INSERT INTO cm45 (Date, RollNumber, Size, WidthInMM, LoomNumber, MTRS1, GWeight, CWeight, NWeight, Average, Date2, Sales, IssueOfLamination, MTRS2, NetWeight1, Total1, Total2, MTRS3, NetWeight2) " +
                           "VALUES (@Date, @RollNumber, @Size, @WidthInMM, @LoomNumber, @MTRS1, @GWeight, @CWeight, @NWeight, @Average, @Date2, @Sales, @IssueOfLamination, @MTRS2, @NetWeight1, @Total1, @Total2, @MTRS3, @NetWeight2)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Date", dataEntity.Date);
                cmd.Parameters.AddWithValue("@RollNumber", dataEntity.RollNumber);
                cmd.Parameters.AddWithValue("@Size", dataEntity.Size);
                cmd.Parameters.AddWithValue("@WidthInMM", dataEntity.WidthInMM);
                cmd.Parameters.AddWithValue("@LoomNumber", dataEntity.LoomNumber);
                cmd.Parameters.AddWithValue("@MTRS1", dataEntity.MTRS);
                cmd.Parameters.AddWithValue("@GWeight", dataEntity.GWeight);
                cmd.Parameters.AddWithValue("@CWeight", dataEntity.CWeight);
                cmd.Parameters.AddWithValue("@NWeight", dataEntity.NWeight);
                cmd.Parameters.AddWithValue("@Average", dataEntity.Average);
                cmd.Parameters.AddWithValue("@Date2", dataEntity.Date2);
                cmd.Parameters.AddWithValue("@Sales", dataEntity.Sales);
                cmd.Parameters.AddWithValue("@IssueOfLamination", dataEntity.IssueOfLamination);
                cmd.Parameters.AddWithValue("@MTRS2", dataEntity.IssueMTRS);
                cmd.Parameters.AddWithValue("@NetWeight1", dataEntity.BalanceNetWeight);
                cmd.Parameters.AddWithValue("@Total1", dataEntity.Total1);
                cmd.Parameters.AddWithValue("@Total2", dataEntity.Total2);
                cmd.Parameters.AddWithValue("@MTRS3", dataEntity.BalanceMTRS);
                cmd.Parameters.AddWithValue("@NetWeight2", dataEntity.BalanceNetWeight);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }



        public List<MM400Entity> RetrieveMM400()        // retrive MM400
        {
            List<MM400Entity> result = new List<MM400Entity>();
            _connection.Open();

            string query = "SELECT * FROM mm400";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MM400Entity entity = new MM400Entity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            RollNumber = reader["RollNumber"].ToString(),
                            Size = reader["Size"].ToString(),
                            WidthInMM = reader["WidthInMM"].ToString(),
                            LoomNumber = reader["LoomNumber"].ToString(),
                            MTRS = reader["MTRS1"].ToString(),
                            GWeight = reader["GWeight"].ToString(),
                            CWeight = reader["CWeight"].ToString(),
                            NWeight = reader["NWeight"].ToString(),
                            Average = reader["Average"].ToString(),
                            Date2 = Convert.ToDateTime(reader["Date2"]),
                            Sales = reader["Sales"].ToString(),
                            IssueOfLamination = reader["IssueOfLamination"].ToString(),
                            IssueMTRS = reader["MTRS2"].ToString(),
                            IssueNetWeight = reader["NetWeight1"].ToString(),
                            Total1 = reader["Total1"].ToString(),
                            Total2 = reader["Total2"].ToString(),
                            BalanceMTRS = reader["MTRS3"].ToString(),
                            BalanceNetWeight = reader["NetWeight2"].ToString()
                        };

                        result.Add(entity);
                    }
                }
            }
            _connection.Close();

            return result;
        }




        public bool InsertMM400(MM400Entity dataEntity)   // insert MM400
        {
            string query = "INSERT INTO mm400 (Date, RollNumber, Size, WidthInMM, LoomNumber, MTRS1, GWeight, CWeight, NWeight, Average, Date2, Sales, IssueOfLamination, MTRS2, NetWeight1, Total1, Total2, MTRS3, NetWeight2) " +
                           "VALUES (@Date, @RollNumber, @Size, @WidthInMM, @LoomNumber, @MTRS1, @GWeight, @CWeight, @NWeight, @Average, @Date2, @Sales, @IssueOfLamination, @MTRS2, @NetWeight1, @Total1, @Total2, @MTRS3, @NetWeight2)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Date", dataEntity.Date);
                cmd.Parameters.AddWithValue("@RollNumber", dataEntity.RollNumber);
                cmd.Parameters.AddWithValue("@Size", dataEntity.Size);
                cmd.Parameters.AddWithValue("@WidthInMM", dataEntity.WidthInMM);
                cmd.Parameters.AddWithValue("@LoomNumber", dataEntity.LoomNumber);
                cmd.Parameters.AddWithValue("@MTRS1", dataEntity.MTRS);
                cmd.Parameters.AddWithValue("@GWeight", dataEntity.GWeight);
                cmd.Parameters.AddWithValue("@CWeight", dataEntity.CWeight);
                cmd.Parameters.AddWithValue("@NWeight", dataEntity.NWeight);
                cmd.Parameters.AddWithValue("@Average", dataEntity.Average);
                cmd.Parameters.AddWithValue("@Date2", dataEntity.Date2);
                cmd.Parameters.AddWithValue("@Sales", dataEntity.Sales);
                cmd.Parameters.AddWithValue("@IssueOfLamination", dataEntity.IssueOfLamination);
                cmd.Parameters.AddWithValue("@MTRS2", dataEntity.IssueMTRS);
                cmd.Parameters.AddWithValue("@NetWeight1", dataEntity.BalanceNetWeight);
                cmd.Parameters.AddWithValue("@Total1", dataEntity.Total1);
                cmd.Parameters.AddWithValue("@Total2", dataEntity.Total2);
                cmd.Parameters.AddWithValue("@MTRS3", dataEntity.BalanceMTRS);
                cmd.Parameters.AddWithValue("@NetWeight2", dataEntity.BalanceNetWeight);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }





        public List<MM850Entity> RetrieveMM850()        // retrive MM850
        {
            List<MM850Entity> result = new List<MM850Entity>();
            _connection.Open();

            string query = "SELECT * FROM mm850";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MM850Entity entity = new MM850Entity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            RollNumber = reader["RollNumber"].ToString(),
                            Size = reader["Size"].ToString(),
                            WidthInMM = reader["WidthInMM"].ToString(),
                            LoomNumber = reader["LoomNumber"].ToString(),
                            MTRS = reader["MTRS1"].ToString(),
                            GWeight = reader["GWeight"].ToString(),
                            CWeight = reader["CWeight"].ToString(),
                            NWeight = reader["NWeight"].ToString(),
                            Average = reader["Average"].ToString(),
                            Date2 = Convert.ToDateTime(reader["Date2"]),
                            Sales = reader["Sales"].ToString(),
                            IssueOfLamination = reader["IssueOfLamination"].ToString(),
                            IssueMTRS = reader["MTRS2"].ToString(),
                            IssueNetWeight = reader["NetWeight1"].ToString(),
                            Total1 = reader["Total1"].ToString(),
                            Total2 = reader["Total2"].ToString(),
                            BalanceMTRS = reader["MTRS3"].ToString(),
                            BalanceNetWeight = reader["NetWeight2"].ToString()
                        };

                        result.Add(entity);
                    }
                }
            }
            _connection.Close();

            return result;
        }




        public bool InsertMM850(MM850Entity dataEntity)   // insert MM400
        {
            string query = "INSERT INTO mm850 (Date, RollNumber, Size, WidthInMM, LoomNumber, MTRS1, GWeight, CWeight, NWeight, Average, Date2, Sales, IssueOfLamination, MTRS2, NetWeight1, Total1, Total2, MTRS3, NetWeight2) " +
                           "VALUES (@Date, @RollNumber, @Size, @WidthInMM, @LoomNumber, @MTRS1, @GWeight, @CWeight, @NWeight, @Average, @Date2, @Sales, @IssueOfLamination, @MTRS2, @NetWeight1, @Total1, @Total2, @MTRS3, @NetWeight2)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Date", dataEntity.Date);
                cmd.Parameters.AddWithValue("@RollNumber", dataEntity.RollNumber);
                cmd.Parameters.AddWithValue("@Size", dataEntity.Size);
                cmd.Parameters.AddWithValue("@WidthInMM", dataEntity.WidthInMM);
                cmd.Parameters.AddWithValue("@LoomNumber", dataEntity.LoomNumber);
                cmd.Parameters.AddWithValue("@MTRS1", dataEntity.MTRS);
                cmd.Parameters.AddWithValue("@GWeight", dataEntity.GWeight);
                cmd.Parameters.AddWithValue("@CWeight", dataEntity.CWeight);
                cmd.Parameters.AddWithValue("@NWeight", dataEntity.NWeight);
                cmd.Parameters.AddWithValue("@Average", dataEntity.Average);
                cmd.Parameters.AddWithValue("@Date2", dataEntity.Date2);
                cmd.Parameters.AddWithValue("@Sales", dataEntity.Sales);
                cmd.Parameters.AddWithValue("@IssueOfLamination", dataEntity.IssueOfLamination);
                cmd.Parameters.AddWithValue("@MTRS2", dataEntity.IssueMTRS);
                cmd.Parameters.AddWithValue("@NetWeight1", dataEntity.BalanceNetWeight);
                cmd.Parameters.AddWithValue("@Total1", dataEntity.Total1);
                cmd.Parameters.AddWithValue("@Total2", dataEntity.Total2);
                cmd.Parameters.AddWithValue("@MTRS3", dataEntity.BalanceMTRS);
                cmd.Parameters.AddWithValue("@NetWeight2", dataEntity.BalanceNetWeight);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }



    }

}
