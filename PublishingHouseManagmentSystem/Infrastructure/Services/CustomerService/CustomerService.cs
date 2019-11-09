using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouseManagmentSystem.Infrastructure.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        public static string connectionString = @"Data Source=NETMONSTER\BIDZINASQL;Initial Catalog = PublishingHouse;User ID = ;Password=;Integrated Security=True;";
        public SqlConnection connection = new SqlConnection(connectionString: connectionString);

        /// <summary>
        /// Signs in manager into system
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool SignInCustomer(string email, string password)
        {
            string query = "Select * from Managers Where Email = @email And Password = @password";
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);

            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows == true)
            {
                connection.Close();
                return true;
            }

            return false;
        }
    }
}
