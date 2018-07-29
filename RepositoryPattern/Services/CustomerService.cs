using RepositoryPattern.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repositories.CustomerRepositories
{
    public class CustomerService
    {
        private readonly CarDBEntities _contex;
        private readonly CustomerRepository _customerRepository;

        private readonly CommonRepository _commonRepository;

        public CustomerService() {
            _contex = new CarDBEntities();
           // _customerRepository=new CustomerRepository(_contex);
            _commonRepository = new CommonRepository(_contex);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _commonRepository.CustomerRepository.GetCustomers();
             //_customerRepository.GetCustomers();
        }

        public Customer GetCustomerById(int customerId)
        {
            return _commonRepository.CustomerRepository.GetCustomerById(customerId);
        }

        public void InsertCustomer(Customer customer)
        {
            // var company=_customerRepository.
            _commonRepository.CustomerRepository.InsertCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _commonRepository.CustomerRepository.UpdateCustomer(customer);
        }
    }
}
