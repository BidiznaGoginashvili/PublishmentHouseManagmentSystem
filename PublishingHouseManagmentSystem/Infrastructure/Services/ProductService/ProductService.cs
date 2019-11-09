using PublishingHouseManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingHouseManagmentSystem.Infrastructure.Services.ProductService
{
    public class ProductService : IProductService
    {
        public static string connectionString = @"Data Source=NETMONSTER\BIDZINASQL;Initial Catalog = PublishingHouse;User ID = ;Password=;Integrated Security=True;";
        #region Methods

        public void InsertArcticle(string title, int pagesAmount, string magazine)
        {
            SqlConnection connection = new SqlConnection(connectionString: connectionString);
            string query = @"INSERT INTO Arcticles (Title,PagesAmount,Magazine,PublicationDate) VALUES (@title,@pagesAmount,@magazine,getDate());";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@pagesAmount", pagesAmount);
            command.Parameters.AddWithValue("@magazine", magazine);

            connection.Open();
            int i = command.ExecuteNonQuery();
            connection.Close();
        }

        public void InsertBook(string title, int pagesAmount, int startPage, int endPage, string publisherCompany, int authorId)
        {
            SqlConnection connection = new SqlConnection(connectionString: connectionString);
            string query = @"INSERT INTO Books (Title,PagesAmount,StartPage,EndPage,PublisherCompany,PublicationDate,AuthorId) VALUES (@title,@pagesAmount,@startPage,@endPage,@publisherCompany,getDate(),@authorId);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@pagesAmount", pagesAmount);
            command.Parameters.AddWithValue("@startPage", startPage);
            command.Parameters.AddWithValue("@endPage", endPage);
            command.Parameters.AddWithValue("@publisherCompany", publisherCompany);
            command.Parameters.AddWithValue("@authorId", authorId);

            connection.Open();
            int i = command.ExecuteNonQuery();
            connection.Close();
        }

        public void InsertEBook(string title, string linkAddress, int pagesAmount)
        {
            SqlConnection connection = new SqlConnection(connectionString: connectionString);
            string query = @"INSERT INTO EBooks (Title,LinkAddress,PagesAmount,PublicationDate) VALUES (@title,@linkAddress,@pagesAmount,getDate());";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@linkAddress", linkAddress);
            command.Parameters.AddWithValue("@pagesAmount", pagesAmount);
            connection.Open();
            int i = command.ExecuteNonQuery();
            connection.Close();
        }

        public void GetArcticles(DataGridView dataGridView, string title = null, DateTime? publishDate = null)
        {
            Search(
                dataGridView,
                tableName: "Arcticles",
                title,
                publishDate);
        }

        public void GetAuthors(DataGridView dataGridView, string title = null)
        {
            var dataAdapter = new SqlDataAdapter();
            var dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString: connectionString);
            string query = @"
                    SELECT FirstName,
                           LastName, 
                           Email,
                           BirthDate,
                           SavingPerPage,
                           Title
                     FROM Authors
                     Inner Join Books book
                         on book.AUTHORID = Authors.ID
                     where  TITLE LIKE '%'+@title+'%'
	                        OR TITLE IS NULL";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", title ?? "");

            connection.Open();
            int i = command.ExecuteNonQuery();

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
            connection.Close();
        }

        public void GetBooks(DataGridView dataGridView, string title = null, DateTime? publishDate = null)
        {
            Search(
                 dataGridView,
                 tableName: "Books",
                 title,
                 publishDate);
        }

        public void GetEBooks(DataGridView dataGridView, string title = null, DateTime? publishDate = null)
        {
            Search(
                 dataGridView,
                 tableName: "EBooks",
                 title,
                 publishDate);
        }

        public Dictionary<int, string> GetAuthorsForPublishment()
        {
            string query = $@"
                    SELECT * 
                        FROM Authors";
            SqlConnection connection = new SqlConnection(connectionString: connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            Dictionary<int, string> authors = new Dictionary<int, string>();

            connection.Open();

            command.ExecuteNonQuery();

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string fullName = dataReader["FirstName"].ToString() + dataReader["LastName"].ToString();
                int id = (int)dataReader["Id"];

                authors.Add(id, fullName);
            }

            connection.Close();

            return authors;
        }

        public void Search(DataGridView dataGridView, string tableName, string title = null, DateTime? publishDate = null)
        {
            string date = publishDate.HasValue ? publishDate.ToString() : "";
            var dataAdapter = new SqlDataAdapter();
            var dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString: connectionString);
            string query = $@"
                    SELECT * FROM 
                    	{tableName} WHERE TITLE LIKE '%'+@title+'%'
	                        OR TITLE IS NULL";

            if (date != "")
            {
                query += $@" OR PublicationDate between '{date}' and '{date}' OR PublicationDate IS NULL";
            }

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", title ?? "");
            command.Parameters.AddWithValue("@date", date ?? "");

            connection.Open();
            int i = command.ExecuteNonQuery();

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
            connection.Close();
        }

        #endregion
    }
}
