
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string TexNumber { get; set; }
        public string CompanyName { get; set; }
        public string CompanyTip { get; set; }
        public string CompanyTaxOffice { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyEmail { get; set; }
        public decimal CompanyBalance { get; set; }
        public string CompanyDistrict { get; set; }
        public string CompanyGroup { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeEmail { get; set; }
        public string DocumentTip { get; set; }
        public string DocumentPhoto { get; set; }
        public bool Status { get; set; }

        public List<Vehicle> Aracs { get; set; }
        public ICollection<Punishment> Punishments { get; set; }
        public ICollection<Structure> Structures { get; set; }
        public ICollection<Filling> Fillings { get; set; }
        public ICollection<OtherStructure> OtherStructures { get; set; }

        public ICollection<Complaint> Complaints { get; set; }
        public ICollection<AltyapıIsler> AltyapıIslers { get; set; }
        public List<CompanyDocument> CompanyDocuments  { get; set; }
        public ICollection<CompanyBalance> CompanyBalances  { get; set; }
      


    }
}
