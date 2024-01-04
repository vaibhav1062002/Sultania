// Repositories/LoginRepository.cs
using MySql.Data.MySqlClient;
using NuGet.Protocol.Plugins;
using SultaniaOil.Models.Login;

public class LoginRepository
{
    private MySqlConnection _connection;

    public LoginRepository()
    {
        string connStr = "server=localhost;database=sultaniyaoil;user=root;password=admin@1234;";
        _connection = new MySqlConnection(connStr);
    }

    public bool ValidateUser(LoginEntity login)
    {
        using (MySqlConnection connection = new MySqlConnection(_connection.ConnectionString))
        {
            connection.Open();

            string query = "SELECT COUNT(*) FROM Autentication WHERE Email = @Email AND Password = @Password";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", login.Email);
                command.Parameters.AddWithValue("@Password", login.Password);

                object result = command.ExecuteScalar();
                int count = Convert.ToInt32(result);
                return count > 0;

            }
        }
    }
}
