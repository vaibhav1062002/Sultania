using MySql.Data.MySqlClient;
using SultaniaOil.Models;

namespace SultaniaOil.Data
{
    public class LoomProReposetory
    {
        //defining varibale 
        MySqlConnection _connection;

        public LoomProReposetory() //constructor  
        {
            //string connStr = @"server=vaibhav\SQLEXPRESS01; database=Eazymr; Integrated Security=true; TrustServerCertificate=true";
            string connStr = "Data Source=localhost; Database=sultaniyaoil; USERID =root; PASSWORD =admin@1234";
            _connection = new MySqlConnection(connStr);
        }

        


             public List<LoomProgramEntity> GetloomPlan() //veiw tape QNT master data 
        {
            List<LoomProgramEntity> result = new List<LoomProgramEntity>();
            _connection.Open();

            string query = "SELECT * FROM loomprogram";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LoomProgramEntity loomProgramEntity = new LoomProgramEntity
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Inches = reader["Inches"].ToString(),
                            Shift = reader["Shift"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            Production = reader["Production"].ToString(),
                            Date = Convert.ToDateTime(reader["Date"])
                        };

                        result.Add(loomProgramEntity);

                    }
                }
            }
            _connection.Close();

            return result;

        }








        public bool InsertLoomPro(LoomProgramEntity loomProData) // inserting loom plane
        {

            string query = "INSERT INTO loomprogram(Inches, Shift, ProductName, Production, Date)   VALUES (@Inches, @Shift, @ProductName, @Production, @Date)";

            using (MySqlCommand cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@Inches", loomProData.Inches);
                cmd.Parameters.AddWithValue("@Shift", loomProData.Shift);
                cmd.Parameters.AddWithValue("@ProductName", loomProData.ProductName);
                cmd.Parameters.AddWithValue("@Production", loomProData.Production);
                cmd.Parameters.AddWithValue("@Date", loomProData.Date);

                _connection.Open();
                int i = cmd.ExecuteNonQuery();
                _connection.Close();

                if (i >= 1) { return true; }
                else { return false; }
            }
        }


      

    }
}
