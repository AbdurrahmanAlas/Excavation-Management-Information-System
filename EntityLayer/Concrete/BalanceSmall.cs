using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class BalanceSmall
    {
        [Key]
        public int BalanceSmallId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int VehicleNumber { get; set; }
        public  DateTime Date { get; set; }
        public decimal TahakkukMiktarı { get; set; }
        public string District { get; set; }
        public int Island { get; set; }
        public int Parcel { get; set; }
        public decimal miktar { get; set; }
        public int SmallVehicleId { get; set; }
        public SmallVehicle SmallVehicle { get; set; }
    }
}
