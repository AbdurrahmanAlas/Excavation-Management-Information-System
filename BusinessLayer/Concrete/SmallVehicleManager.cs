using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SmallVehicleManager : ISmallVehicleService
    {
        ISmallVehicleDal _smallVehicleDal;

        public SmallVehicleManager(ISmallVehicleDal smallVehicleDal)
        {
            _smallVehicleDal = smallVehicleDal;
        }

        public List<SmallVehicle> GetList()
        {
            return _smallVehicleDal.GetListAll();
        }

        public void TAdd(SmallVehicle t)
        {
            _smallVehicleDal.Insert(t);
        }

        public void TDelete(SmallVehicle t)
        {
            _smallVehicleDal.Delete(t);
        }

        public SmallVehicle TGetById(int id)
        {
            return _smallVehicleDal.GetByID(id);
        }

        public void TUpdate(SmallVehicle t)
        {
            _smallVehicleDal.Update(t);
        }
    }
}
