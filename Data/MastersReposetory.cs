
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using SultaniaOil.Models;

namespace SultaniaOil.Data

{

    public class MastersReposetory
    {
        //defining varibale 
        MySqlConnection _connection;

        public MastersReposetory() //constructor  
        {
            //string connStr = @"server=vaibhav\SQLEXPRESS01; database=Eazymr; Integrated Security=true; TrustServerCertificate=true";
            string connStr = "Data Source=localhost; Database=sultaniyaoil; USERID =root; PASSWORD =admin@1234";
            _connection = new MySqlConnection(connStr);
        }






        // for Retrive all masters data  start ........

        public List<MastersEntity> GetBagType() // view bagmaster data 
        {
            List<MastersEntity> result = new List<MastersEntity>();
            _connection.Open();

            string query = "SELECT * FROM bagtypemaster";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MastersEntity mastersEntity = new MastersEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Bagtype = reader["Bagtype"].ToString(),
                            DATE = Convert.ToDateTime(reader["DATE"]),
                        };

                        result.Add(mastersEntity);


                    }
                }
            }
            _connection.Close();

            return result;

        }


        public List<ColorEntity> GetColorDetails() //veiw color master data 
        {
            List<ColorEntity> result = new List<ColorEntity>();
            _connection.Open();

            string query = "SELECT * FROM colormaster";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ColorEntity colorEntity = new ColorEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Color = reader["color"].ToString(),
                            ColorCode = reader["ColorCode"].ToString(),
                            DATE = Convert.ToDateTime(reader["DATE"]),
                        };

                        result.Add(colorEntity);


                    }
                }
            }
            _connection.Close();

            return result;

        }


        public List<TypeQLTEntity> GetTapeQLT() //veiw tape QNT master data 
        {
            List<TypeQLTEntity> result = new List<TypeQLTEntity>();
            _connection.Open();

            string query = "SELECT * FROM tapeqltmaster";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TypeQLTEntity tapeQNT = new TypeQLTEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Jobcode = reader["Jobcode"].ToString(),
                            DATE = Convert.ToDateTime(reader["DATE"]),
                        };

                        result.Add(tapeQNT);

                    }
                }
            }
            _connection.Close();

            return result;

        }


        public List<GradeEntity> RetriveGrade() // retrive Grade
        {
            List<GradeEntity> result = new List<GradeEntity>();
            _connection.Open();

            string query = "SELECT * FROM grade ORDER BY Id DESC";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GradeEntity gradeEntity = new GradeEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Grade = reader["Grade"].ToString(),
                        };

                        result.Add(gradeEntity);


                    }
                }
            }
            _connection.Close();

            return result;

        }

        public List<VendorEntity> RetriveVendor()// retrive vendors 

        {
            List<VendorEntity> result = new List<VendorEntity>();
            _connection.Open();

            string query = "SELECT * FROM VendorDetails ORDER BY Id DESC";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        VendorEntity vendor = new VendorEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            MobileNumber = reader["MobileNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Address = reader["Address"].ToString(),
                            GSTNumber = reader["GSTNumber"].ToString(),
                            GSTImage = reader["GSTImage"].ToString(),
                        };

                        result.Add(vendor);
                    }
                }
            }

            _connection.Close();

            return result;
        }



        public List<ProductEntity> RetriveProduct() // retrive Product
        {
            List<ProductEntity> result = new List<ProductEntity>();
            _connection.Open();

            string query = "SELECT * FROM Product ORDER BY Id DESC";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductEntity productEntity = new ProductEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Product = reader["Product"].ToString(),
                        };

                        result.Add(productEntity);


                    }
                }
            }
            _connection.Close();

            return result;

        }


        public List<LoomEntity> RetriveLoom() // retrive Loom
        {
            List<LoomEntity> result = new List<LoomEntity>();
            _connection.Open();

            string query = "SELECT * FROM loom ORDER BY Id DESC";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LoomEntity loomEntity = new LoomEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Loom = reader["Loom"].ToString(),
                        };

                        result.Add(loomEntity);


                    }
                }
            }
            _connection.Close();

            return result;

        }


        public List<BobbinEntity> RetriveBobbin() // retrive Bobbin
        {
            List<BobbinEntity> result = new List<BobbinEntity>();
            _connection.Open();

            string query = "SELECT * FROM bobbin ORDER BY Id DESC";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BobbinEntity bobbinEntity = new BobbinEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Bobbin = reader["Bobbin"].ToString(),
                        };

                        result.Add(bobbinEntity);


                    }
                }
            }
            _connection.Close();

            return result;

        }


        public List<JobCodeEntity> RetriveJobCode() // retrive JobCodes
        {
            List<JobCodeEntity> result = new List<JobCodeEntity>();
            _connection.Open();

            string query = "SELECT * FROM jobcode ORDER BY Id DESC";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        JobCodeEntity jobCodeEntity = new JobCodeEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            JobCode = reader["JobCode"].ToString(),
                        };

                        result.Add(jobCodeEntity);


                    }
                }
            }
            _connection.Close();

            return result;

        }








        // insert all data *************************************************************

        public bool InsertBagType(MastersEntity BagtypeEntity) //insertBagType
        {

            string query = "INSERT INTO bagtypemaster(Bagtype) VALUES(@Bagtype)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Bagtype", BagtypeEntity.Bagtype);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                if (i >= 1) { return true; }
                else { return false; }
            }
        }


        public bool InsertColorDetails(ColorEntity colorEntity) //insert Color Details
        {

            string query = "INSERT INTO colormaster(Color,ColorCode) VALUES(@Color, @ColorCode)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Color", colorEntity.Color);
                cmd.Parameters.AddWithValue("@ColorCode", colorEntity.ColorCode);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                if (i >= 1) { return true; }
                else { return false; }
            }
        }



        public bool InsertTapeQlt(TypeQLTEntity typeQLTEntity) // insert Tape QNT
        {

            string query = "INSERT INTO tapeqltmaster(Jobcode) VALUES(@Jobcode)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Jobcode", typeQLTEntity.Jobcode);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                if (i >= 1) { return true; }
                else { return false; }
            }
        }
     

        public bool InsertGrade(GradeEntity gradeEntity)     // insert Grade
        {

            string query = "INSERT INTO grade(Grade) VALUES(@Grad)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Grad", gradeEntity.Grade);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                if (i >= 1) { return true; }
                else { return false; }
            }
        }   

        public bool InsertVendor(VendorEntity vendorEntity)     // insert Vendor
        {
            string query = "INSERT INTO VendorDetails(Name, MobileNumber, Email, Address,GSTNumber, GSTImage) VALUES(@Name, @MobileNumber, @Email, @Address,@GSTNumber,@GSTImage)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Name", vendorEntity.Name);
                cmd.Parameters.AddWithValue("@MobileNumber", vendorEntity.MobileNumber);
                cmd.Parameters.AddWithValue("@Email", vendorEntity.Email);
                cmd.Parameters.AddWithValue("@Address", vendorEntity.Address);
                cmd.Parameters.AddWithValue("@GSTNumber", vendorEntity.GSTNumber);
                cmd.Parameters.AddWithValue("@GSTImage", vendorEntity.GSTImage);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }    
   
        
        public bool InsertProduct(ProductEntity productEntity)     // insert product
        {

            string query = "INSERT INTO Product(Product) VALUES(@Product)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Product", productEntity.Product);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                if (i >= 1) { return true; }
                else { return false; }
            }
        }


        public bool InsertGrade(LoomEntity loomEntity)     // insert Loom
        {

            string query = "INSERT INTO loom(Loom) VALUES(@Loom)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Loom", loomEntity.Loom);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                if (i >= 1) { return true; }
                else { return false; }
            }
        }



        public bool InsertBobbin(BobbinEntity bobbinEntity)     // insert Bobbin
        {

            string query = "INSERT INTO bobbin(Bobbin) VALUES(@Bobbin)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Bobbin", bobbinEntity.Bobbin);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                if (i >= 1) { return true; }
                else { return false; }
            }
        }



        public bool InsertJobCode(JobCodeEntity jobCodeEntity)     // insert Bobbin
        {

            string query = "INSERT INTO jobcode(JobCode) VALUES(@JobCode)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@JobCode", jobCodeEntity.JobCode);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                if (i >= 1) { return true; }
                else { return false; }
            }
        }













        // delete functionality for all masters ************************************************************************

        public bool DaleteBagType(int Id) //Delete bagtype
        {
            string query = "DELETE FROM bagtypemaster WHERE Id = @Id";
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



        public bool DeleteColor(int Id) //Delete color
        {
            string query = "DELETE FROM colormaster WHERE Id = @Id";
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




        public bool DaleteGrade(string Id) //Delete Grade
        {
            string query = "DELETE FROM grade WHERE Id = @Id";
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



        public bool DaleteProduct(int Id) //Delete Product
        {
            string query = "DELETE FROM Product WHERE Id = @Id";
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


        public bool DaleteTapeQNT(int Id) //Delete TapeQNT
        {
            string query = "DELETE FROM tapeqltmaster WHERE Id = @Id";
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


        public bool DaleteVendor(int Id) //Delete TapeQNT
        {
            string query = "DELETE FROM VendorDetails WHERE Id = @Id";
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





        public bool DaleteLoom(string Id) //Delete Loom
        {
            string query = "DELETE FROM loom WHERE Id = @Id";
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


        public bool DaleteBobbin(string Id) //Delete bobbin
        {
            string query = "DELETE FROM bobbin WHERE Id = @Id";
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



        public bool DaleteJobCode(string Id) //Delete JobCode
        {
            string query = "DELETE FROM jobcode WHERE Id = @Id";
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
