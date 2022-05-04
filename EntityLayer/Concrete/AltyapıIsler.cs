using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class AltyapıIsler
    {
        [Key]
        public int lowerId { get; set; }
        public string WorkName{ get; set; }
        public string ProjectName{ get; set; }
        public DateTime  LocationDate{ get; set; }
        public DateTime  FınıshDate{ get; set; }
        public string  IhaleNo{ get; set; }
        public string District { get; set; }
        public string ProjectPerson { get; set; }
        public string ProjectPersonPhone { get; set; }
        public string Description { get; set; }
        public string IhaleDökuman { get; set; }
        public DateTime IhaleDate { get; set; }
        public string ProjectDökuman { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
