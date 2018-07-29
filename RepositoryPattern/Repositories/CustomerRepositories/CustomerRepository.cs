using RepositoryPattern.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repositories.CustomerRepositories
{
  public class CustomerRepository
    {
        private readonly CarDBEntities _contex;
       public CustomerRepository(CarDBEntities contex) {
            _contex = contex;

        }

        public IEnumerable<Customer> GetCustomers() {            
            return _contex.Customers.ToList();
        }

        public Customer GetCustomerById(int CustomerId)
        {
            return _contex.Customers.Where(x=>x.Id==CustomerId).FirstOrDefault();
        }

        public void InsertCustomer(Customer customer) {
            _contex.Customers.Add(customer);
            _contex.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _contex.Customers.AddOrUpdate(customer);
            _contex.SaveChanges();
        }
    }
}
