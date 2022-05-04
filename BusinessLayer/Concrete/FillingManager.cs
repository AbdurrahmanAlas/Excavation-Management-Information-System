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
    public class FillingManager : IFillingService
    {
        IFillingDal _fillingDal;

        public FillingManager(IFillingDal fillingDal)
        {
            _fillingDal = fillingDal;
        }

        public void FillingAdd(Filling filling)
        {
            _fillingDal.Insert(filling);        }

        public void FillingDelete(Filling filling)
        {
            _fillingDal.Delete(filling);
        }

        public void FillingUpdate(Filling filling)
        {
            _fillingDal.Update(filling);
        }

        public Filling GetById(int id)
        {
            return _fillingDal.GetByID(id);
        }

        public List<Filling> GetFillingWithCompany()
        {
            return _fillingDal.GetFillingByCompany();
        }

        public List<Filling> GetList(int id)
        {
            return _fillingDal.GetListAll();
        }
    }
}
