using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYBS.Models
{
    public class AddVehicleImage
    {
        public int VehicleId { get; set; }
        public IFormFile VehicleImage { get; set; }
        public string VehiclePlaka { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleYear { get; set; }
        public string VehicleTip { get; set; }
        public string VehicleHGS { get; set; }
        public string VehicleIMEI { get; set; }
        public string VehicleDara { get; set; }
        public string VehicleIzinBitis { get; set; }
        public string DocumentName { get; set; }
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
