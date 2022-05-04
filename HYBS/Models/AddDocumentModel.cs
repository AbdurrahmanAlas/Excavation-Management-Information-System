using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.Models
{
    public class AddDocumentModel
    {
        public int CompanyDocumentId { get; set; }
        public string DocumentName { get; set; }
        public IFormFile DocumentPhoto { get; set; }
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
