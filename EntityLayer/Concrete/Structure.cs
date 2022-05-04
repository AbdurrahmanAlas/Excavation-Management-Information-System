using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Structure
    {
        [Key]
        public int StructureId { get; set; }
        public string CompanyName { get; set; }
        public string Reason { get; set; }
        public string PermitNumber { get; set; }
        public string VehiclePlaka { get; set; }
        public string ÜreticiName { get; set; }
        public string ÜreticiPhone { get; set; }
        public string ÜreticiAddress { get; set; }
        public int Island { get; set; }
        public int Parcel { get; set; }
        public string Blok { get; set; }
        public string District { get; set; }
        public string Mahalle { get; set; }
        public string  Excavation { get; set; }
        public string  Filling { get; set; }
        public string  EmptyExcavation { get; set; }
        public string  Atıkcinsi { get; set; }
        public string  Casting { get; set; }
        public string  ExcavationAddress { get; set; }
        public string  Note { get; set; }
        public decimal Kazı { get; set; }
        public decimal Dolgu { get; set; }
        public string  DocumentName { get; set; }
        public string  DocumentPhoto { get; set; }
        public string  DocumentTipi { get; set; }
        public DateTime OnayDate { get; set; }
       public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
