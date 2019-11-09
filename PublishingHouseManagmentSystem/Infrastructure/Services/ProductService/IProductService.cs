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
    public interface IProductService
    {
        void InsertBook(string title, int pagesAmount, int startPage, int endPage, string publisherCompany, int authorId);

        void InsertArcticle(string title, int pagesAmount, string magazine);

        void InsertEBook(string title, string linkAddress, int pagesAmount);

        void GetAuthors(DataGridView dataGridView, string title = null);

        void GetArcticles(DataGridView dataGridView, string title = null, DateTime? publishDate = null);

        void GetBooks(DataGridView dataGridView, string title = null, DateTime? publishDate = null);

        void GetEBooks(DataGridView dataGridView, string title = null, DateTime? publishDate = null);

        Dictionary<int, string> GetAuthorsForPublishment();
    }
}
