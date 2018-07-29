using RepositoryPattern.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repositories.CustomerRepositories
{
   public class CommonRepository
    {
        private readonly CarDBEntities _contex;
        public CustomerRepository CustomerRepository;
        public CompanyRepository CompanyRepository;
        public CommonRepository(CarDBEntities contex) {
            _contex = contex;
            CustomerRepository = new CustomerRepository(_contex);
            CompanyRepository = new CompanyRepository(_contex);
        }


        public void SaveChanges()
        {
            _contex.SaveChanges();
        }


    }
}
