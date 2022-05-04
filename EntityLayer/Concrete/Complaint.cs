using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Complaint
    {
        [Key]
        public int ComplaintId { get; set; }
        public string CompanyName { get; set; }
        public string Reason { get; set; }
        public string Complainant { get; set; }
        public string ComplainantPhone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CloseDate { get; set; }

        public string lookperson { get; set; }
        public string Conclusion { get; set; }
        public string Process { get; set; }
        public Company Company { get; set; }
        

    }
}
