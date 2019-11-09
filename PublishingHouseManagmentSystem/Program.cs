using PublishingHouseManagmentSystem.Infrastructure.Services.CustomerService;
using PublishingHouseManagmentSystem.Infrastructure.Services.ProductService;
using System;
using System.Windows.Forms;

namespace PublishingHouseManagmentSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IProductService productService = new ProductService();
            ICustomerService customerService = new CustomerService();
            Application.Run(new SignInForm(customerService,productService));
        }
    }
}
