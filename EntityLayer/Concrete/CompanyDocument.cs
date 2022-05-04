using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class CompanyDocument
    {

        public int CompanyDocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPhoto { get; set; }
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
