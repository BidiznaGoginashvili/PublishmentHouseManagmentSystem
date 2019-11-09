using PublishingHouseManagmentSystem.Infrastructure.Services.ProductService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublishingHouseManagmentSystem
{
    public partial class PublishForm : Form
    {
        private string _tableName { get; set; }
        private readonly IProductService _productService;
        public PublishForm()
        {
            InitializeComponent();
        }

        public PublishForm(string tableName, IProductService productService)
        {
            InitializeComponent();
            this._tableName = tableName;
            this._productService = productService;
        }

        private void PublishForm_Load(object sender, EventArgs e)
        {
            if (_tableName == "Arcticles")
            {
                LinkAddress.Hide();
                AddressLabel.Hide();
                StartPage.Hide();
                EndPage.Hide();
            }
            if (_tableName == "Books")
            {
                Dictionary<int, string> dict = _productService.GetAuthorsForPublishment();
                AuthorsCombo.DataSource = new BindingSource(dict, null);
                AuthorsCombo.DisplayMember = "Value";
                AuthorsCombo.ValueMember = "Key";
                LinkAddress.Hide();
                AddressLabel.Hide();
            }
            else
            {
                StartPage.Hide();
                EndPage.Hide();
            }
        }

        private void PublishButton_Click(object sender, EventArgs e)
        {
            bool success = true;
            if (_tableName == "Books")
            {
                int authorId = (int)AuthorsCombo.SelectedValue;

                if (authorId > 0)
                {
                    _productService.InsertBook(TitleTxt.Text, Convert.ToInt32(PagesAmount.Value),
                            Convert.ToInt32(StartPage.Value), Convert.ToInt32(EndPage.Value),
                            PublisherName.Text, authorId);
                }
                else
                {
                    success = false;
                }
            }
            else if (_tableName == "EBooks")
            {
                _productService.InsertEBook(TitleTxt.Text, LinkAddress.Text,
                        Convert.ToInt32(PagesAmount.Value));
            }
            else
            {
                _productService.InsertArcticle(TitleTxt.Text, Convert.ToInt32(PagesAmount.Value),
                        PublisherName.Text);
            }

            var successMessage = success ? MessageBox.Show($"{_tableName} Succesfully Published") : MessageBox.Show($"Unsuccesfully Publisment Attempt...");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
