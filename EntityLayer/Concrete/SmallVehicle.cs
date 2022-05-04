using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SmallVehicle
    {
        [Key]
        public int SmallVehicleId { get; set; }
        public string Plaka { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SmallVehicleType { get; set; }
        public string VergiNo { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }
        public ICollection<BalanceSmall> BalanceSmalls { get; set; }
    }
}
