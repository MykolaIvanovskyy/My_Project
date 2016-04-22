using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Models.Abstract;

namespace Assignment.Models.Concrete
{
    public class CompanyRepository : ICompanyRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Company> Companies
        {
            get
            {
                return context.Companies;
            }
        }
        private void ChangeParentId(Company dbEntry)
        {
            var element = context.Companies.Where(l => l.CompanyParentId == dbEntry.CompanyId);
            if (element != null)
            {
                foreach (var el in element)
                {
                    el.CompanyParentId = dbEntry.CompanyParentId;
                    SaveCompany(el);
                }
            }
        }
        public Company DeleteCompany(int companyId)
        {
            Company dbEntry = context.Companies.Find(companyId);
            if (dbEntry != null)
            {
                ChangeParentId(dbEntry);
                context.Companies.Remove(dbEntry);
                context.SaveChanges();
                
            }

            return dbEntry;
        }

        public Company SaveCompany(Company company)
        {
            if (company.CompanyId == 0)
            {
                context.Companies.Add(company);
            }
            else
            {
                Company dbEntry = context.Companies.Find(company.CompanyId);
                if (dbEntry != null) 
                {
                    dbEntry.Name = company.Name;
                    dbEntry.AnnualEarnings = company.AnnualEarnings;
                    


                    dbEntry.CompanyParentId = company.CompanyParentId;
                                                         
                }
            }
            context.SaveChanges();
            return company;
        }

        

        public Company Get(int id)
        {
            return context.Companies.Where(c => c.CompanyId == id).FirstOrDefault();
        }
    }
}