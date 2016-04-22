using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models.Abstract
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> Companies { get; }
        Company SaveCompany(Company company);
        Company DeleteCompany(int companyId);
        Company Get(int id);
    }
}