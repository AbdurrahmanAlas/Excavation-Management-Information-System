using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class VehicleManager : IVehicleService
    {
        IVehicleDal _vehicleDal;

        public VehicleManager(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;
        }

        public Vehicle GetById(int id)
        {
            return _vehicleDal.GetByID(id);
        }

        public List<Vehicle> GetList(int id)
        {
            return _vehicleDal.GetListAll(x => x.CompanyId == id);
        }

        public List<Vehicle> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetVehicleWithCompany()
        {
            return _vehicleDal.GetListWithCompany();
        }

        public void VehicleAdd(Vehicle vehicle)
        {
            _vehicleDal.Insert(vehicle);
        }

        public void VehicleDelete(Vehicle vehicle)
        {
            _vehicleDal.Delete(vehicle);
        }

        public void VehicleUpdate(Vehicle vehicle)
        {
            _vehicleDal.Update(vehicle);
        }
    }
}
