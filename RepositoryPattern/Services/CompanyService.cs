using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.DataLayer;
using System.Data.Entity.Migrations;

namespace RepositoryPattern.Repositories.CustomerRepositories
{
    public class CompanyService
    {

        private readonly CarDBEntities _contex;
        private readonly CompanyRepository _companyRepository;
        private readonly CommonRepository _commonRepository;
        public CompanyService()
        {
            _contex = new CarDBEntities();
           // _companyRepository = new CompanyRepository(_contex);
            _commonRepository = new CommonRepository(_contex);
                      
        }        


        public IEnumerable<CompanyDetail> GetCompanies()
        {
            return _commonRepository.CompanyRepository.GetCompanies();
        }

        public CompanyDetail GetCompanyById(int CompanyId)
        {
            return _commonRepository.CompanyRepository.GetCompanyById(CompanyId);
        }

        public void InsertCompany(CompanyDetail company)
        {
            _commonRepository.CompanyRepository.InsertCompany(company);
        }

        public void UpdateCompany(CompanyDetail company)
        {
            _commonRepository.CompanyRepository.UpdateCompany(company);
        }
       
    }
}
