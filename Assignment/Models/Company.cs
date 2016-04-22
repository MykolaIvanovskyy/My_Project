using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public int AnnualEarnings { get; set; }
        public int CompanyParentId { get; set; }
    }
}