using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IFillingService
    {
        void FillingAdd(Filling filling);
        void FillingDelete(Filling filling);
        void FillingUpdate(Filling filling);
        List<Filling> GetList(int id);
        Filling GetById(int id);
        List<Filling> GetFillingWithCompany();
    }
}
