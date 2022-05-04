using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IVehicleService
    {
        void VehicleAdd(Vehicle vehicle);
        void VehicleDelete(Vehicle vehicle);
        void VehicleUpdate(Vehicle vehicle);
        List<Vehicle> GetList(int id);
        Vehicle GetById(int id);
        List<Vehicle> GetVehicleWithCompany();
    }
}
