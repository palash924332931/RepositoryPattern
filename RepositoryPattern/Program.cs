using RepositoryPattern.DataLayer;
using RepositoryPattern.Repositories.CustomerRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.SaveUserDetails();
        }

        public void SaveUserDetails()
        {

            CompanyDetail companyDe = new CompanyDetail();
            companyDe.CompanyName = "IMS Health";
            companyDe.CompanyAddress = "Mohakhali";

            Customer cus = new Customer();
            cus.Name = "Palash";
            cus.FatherName = "X";
            cus.MobileNo = "019243329321";
            cus.CompanyDetail = companyDe;

            CarDBEntities contex = new CarDBEntities();
            //contex.Customers.Add(cus);
            //contex.SaveChanges();

            //
            CustomerService customerService = new CustomerService();
            CompanyService companyService = new CompanyService();

            //for insert 
            companyService.InsertCompany(companyDe);
            customerService.InsertCustomer(cus);


            //return 
            IEnumerable<Customer> customerList = customerService.GetCustomers();
            //error 

            IEnumerable<CompanyDetail> companyList = companyService.GetCompanies();


        }
    }


}
