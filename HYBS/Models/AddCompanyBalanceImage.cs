using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.Models
{
    public class AddCompanyBalanceImage
    {
        public int CompanyBalanceID { get; set; }
        public string DocumentName { get; set; }
        public string FillArea { get; set; }
        public decimal Amount { get; set; }
        public decimal miktar { get; set; }
        public string District { get; set; }
        public int Island { get; set; }
        public int Parcel { get; set; }
        public DateTime DateTime { get; set; }
        public IFormFile DocumentPhoto { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
