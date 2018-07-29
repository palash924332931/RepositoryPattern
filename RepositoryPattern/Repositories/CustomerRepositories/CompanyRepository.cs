using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.DataLayer;
using System.Data.Entity.Migrations;

namespace RepositoryPattern.Repositories.CustomerRepositories
{
    public class CompanyRepository
    {
        private readonly CarDBEntities _contex;
        private CommonRepository _commonRepository;
        public CompanyRepository(CarDBEntities contex)
        {
            _contex = contex;
            _commonRepository=new CommonRepository(_contex);
        }

        public IEnumerable<CompanyDetail> GetCompanies()
        {
            return _contex.CompanyDetails.ToList();
        }

        public CompanyDetail GetCompanyById(int CompanyId)
        {
            return _contex.CompanyDetails.Where(x => x.CompanyId == CompanyId).FirstOrDefault();
        }

        public void InsertCompany(CompanyDetail company)
        {

            _contex.CompanyDetails.Add(company);
            _commonRepository.SaveChanges();
        }

        public void UpdateCompany(CompanyDetail company)
        {
            _contex.CompanyDetails.AddOrUpdate(company);
            SaveChanges();
        }

      
    }
}
