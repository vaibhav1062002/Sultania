using MySql.Data.MySqlClient;
using SultaniaOil.Models;

namespace SultaniaOil.Data
{
    public class RawMateirialsReposetory
    {
        //defining varibale 
        MySqlConnection _connection;

        public RawMateirialsReposetory() //constructor  
        {
            //string connStr = @"server=vaibhav\SQLEXPRESS01; database=Eazymr; Integrated Security=true; TrustServerCertificate=true";
            string connStr = "Data Source=localhost; Database=sultaniyaoil; USERID =root; PASSWORD =admin@1234";
            _connection = new MySqlConnection(connStr);
        }



        public List<RawMaterialEntity> RetrivePurches() // retrive purches raw materials 
        {
            List<RawMaterialEntity> result = new List<RawMaterialEntity>();
            _connection.Open();

            string query = "SELECT * FROM rawmaterials ORDER BY Id DESC";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RawMaterialEntity rawMaterialEntity = new RawMaterialEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            PartyName = reader["PartyName"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            GradeName = reader["GradeName"].ToString(),
                            Quantity = reader["Quantity"].ToString(),
                        };

                            result.Add(rawMaterialEntity);


                    }
                }
            }
            _connection.Close();

            return result;

        }




        public bool InsertRawMaterial(RawMaterialEntity rawMaterialEntity)     // insert rawmaterials  
        {
            string query = "INSERT INTO rawmaterials(Date, PartyName, ProductName, GradeName, Quantity) " +
                           "VALUES(@Date, @PartyName, @ProductName, @GradeName, @Quantity)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Date", rawMaterialEntity.Date);
                cmd.Parameters.AddWithValue("@PartyName", rawMaterialEntity.PartyName);
                cmd.Parameters.AddWithValue("@ProductName", rawMaterialEntity.ProductName);
                cmd.Parameters.AddWithValue("@GradeName", rawMaterialEntity.GradeName);
                cmd.Parameters.AddWithValue("@Quantity", rawMaterialEntity.Quantity);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                return i >= 1;
            }
        }




        public bool Daletepurchase(int Id) //Delete raw materials
        {
            string query = "DELETE FROM rawmaterials WHERE Id = @Id";
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
