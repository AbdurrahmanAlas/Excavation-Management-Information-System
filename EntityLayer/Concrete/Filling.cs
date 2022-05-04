using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Filling
    {
        [Key]
        public int FillingId { get; set; }
        public string CompanyName { get; set; }
        public DateTime Tarih { get; set; }
        public string District { get; set; }
        public string mahalle { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public int StartIsland { get; set; }
        public int FınıshIsland { get; set; }
        public int StartParcel { get; set; }
        public int FınıshParcel { get; set; }
        public string StartDistrict { get; set; }
        public string FınıshDıstrıct { get; set; }
        public  int VehicleNumber{ get; set; }
        public  string Vehicle{ get; set; }
        public  string TalepEden { get; set; }
        public  string Phone{ get; set; }
        public  decimal Kazı{ get; set; }
        public  decimal Dolgu{ get; set; }
        public  bool Status{ get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
        
    }
}
