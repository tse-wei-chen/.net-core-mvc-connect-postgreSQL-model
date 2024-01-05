using Npgsql;
using System.Data;

namespace test.Models
{
    public class ConnNpgModel
    {
        string cs = "Host=localhost;Username=postgres;Password=root8888;Database=restaurant";
        NpgsqlConnection con;

        public ConnNpgModel()
        {
            con = new NpgsqlConnection(cs);
        }

        public void ConnectToDB()
        {
            try
            {
                con.Open();
                Console.WriteLine("Connected to PostgreSQL database!");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                Console.WriteLine("Connection closed.");
            }
        }
    }
}