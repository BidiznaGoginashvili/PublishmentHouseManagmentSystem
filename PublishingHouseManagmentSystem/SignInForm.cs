using PublishingHouseManagmentSystem.Infrastructure.Services.CustomerService;
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
    public partial class SignInForm : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        public static string userName;

        public SignInForm()
        {
            InitializeComponent();
        }

        public SignInForm(ICustomerService customerService,
            IProductService productService)
        {
            InitializeComponent();
            _customerService = customerService;
            _productService = productService;
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            var success = _customerService.SignInCustomer(EmailText.Text, PasswordText.Text);

            if (success)
            {
                this.Hide();
                var managmentForm = new ManagmentForm(_productService);
                managmentForm.Closed += (s, args) => this.Close();
                managmentForm.Show();
            }
            else
            {
                MessageBox.Show("Customer can't be found");
            }
        }

        private void ExitSignInBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
