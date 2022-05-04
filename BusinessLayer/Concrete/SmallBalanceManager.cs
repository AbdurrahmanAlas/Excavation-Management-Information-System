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
    public class SmallBalanceManager : ISmallBalanceService
    {
        ISmallBalanceDal _smallBalanceDal;

        public SmallBalanceManager(ISmallBalanceDal smallBalanceDal)
        {
            _smallBalanceDal = smallBalanceDal;
        }

        public List<BalanceSmall> GetList()
        {
           return _smallBalanceDal.GetListAll();
        }

        public List<BalanceSmall> GetListWithSmallVehicle()
        {
            return _smallBalanceDal.GetListWithSmallVehicle();
        }

        public void TAdd(BalanceSmall t)
        {
            _smallBalanceDal.Insert(t);
        }

        public void TDelete(BalanceSmall t)
        {
            _smallBalanceDal.Delete(t);
        }

        public BalanceSmall TGetById(int id)
        {
            return _smallBalanceDal.GetByID(id);

        }

        public void TUpdate(BalanceSmall t)
        {
            _smallBalanceDal.Update(t);
        }
    }
}
