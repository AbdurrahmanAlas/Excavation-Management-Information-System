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
    public class AltyapıManager : IAltyapıService
    {
        IAltyapıDal _altyapıDal;

        public AltyapıManager(IAltyapıDal altyapıDal)
        {
            _altyapıDal = altyapıDal;
        }

        public List<AltyapıIsler> GetList()
        {
            return _altyapıDal.GetListAll();
        }

        public List<AltyapıIsler> GetVehicleWithCompany()
        {
            return _altyapıDal.GetListWithCompany();
        }

        public void TAdd(AltyapıIsler t)
        {
            _altyapıDal.Insert(t);
        }

        public void TDelete(AltyapıIsler t)
        {
            _altyapıDal.Delete(t);
        }

        public AltyapıIsler TGetById(int id)
        {
            return _altyapıDal.GetByID(id);
        }

        public void TUpdate(AltyapıIsler t)
        {
            _altyapıDal.Update(t);
        }
    }
}
