using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.Models
{
    public class AddCezaImage
    {
        public int CezaId { get; set; }
        public string DocumentTipi { get; set; }
        public string CompanyName { get; set; }
        public string CezaTeam { get; set; }
        public string Description { get; set; }
        public string Plaka { get; set; }
        public string DocumentName { get; set; }
        public IFormFile CezaPhoto { get; set; }
        public decimal CezaAmont { get; set; }
        public bool Status { get; set; }
        public DateTime CezaDate { get; set; }
        public int? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
