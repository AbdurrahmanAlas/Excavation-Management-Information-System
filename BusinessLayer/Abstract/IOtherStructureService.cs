using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IOtherStructureService
    {
        void AddOtherStructure(OtherStructure otherStructure);
        void DeleteOtherStructure(OtherStructure otherStructure);
        void UpdateOtherStructure(OtherStructure otherStructure);
        List<OtherStructure> GetList();
        OtherStructure GetByID(int id);

        List<OtherStructure> GetListByCompany();

    }
}
