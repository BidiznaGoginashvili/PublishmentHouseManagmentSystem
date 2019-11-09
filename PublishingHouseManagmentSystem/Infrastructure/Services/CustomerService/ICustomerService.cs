using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingHouseManagmentSystem.Infrastructure.Services.CustomerService
{
    public interface ICustomerService
    {
        bool SignInCustomer(string email, string password);
    }
}
