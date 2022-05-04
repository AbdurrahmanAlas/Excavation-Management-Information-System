using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class CompanyBalance
    {
        [Key]
        public int CompanyBalanceID { get; set; }
        public string DocumentName { get; set; }
        public string FillArea { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; }
        public string DocumentPhoto { get; set; }
        public decimal miktar { get; set; }
        public string District { get; set; }
        public int Island { get; set; }
        public int Parcel { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
