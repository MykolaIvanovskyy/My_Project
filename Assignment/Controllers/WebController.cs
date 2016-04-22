using Assignment.Models;
using Assignment.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment.Controllers
{
    public class WebController : ApiController
    {
        private ICompanyRepository repository;

        public IEnumerable<ICompanyRepository> GetAll()
        {
            return (IEnumerable<ICompanyRepository>)repository.Companies;
        }

       public void Delete(int id)
        {
            repository.DeleteCompany(id);
        }

        public Company PutCompany(Company company)
        {
            return repository.SaveCompany(company);
        }
        public Company PostCompany(Company company)
        {
            return repository.SaveCompany(company);
        }
        public Company GetCompany(int id)
        {
            return repository.Get(id);
        }
    }
}
