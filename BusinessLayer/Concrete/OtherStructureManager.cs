using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OtherStructureManager : IOtherStructureService
    {
        IOtherStructureDal _otherstructure;

        public OtherStructureManager(IOtherStructureDal otherstructure)
        {
            _otherstructure = otherstructure;
        }

        public void AddOtherStructure(OtherStructure otherStructure)
        {
            _otherstructure.Insert(otherStructure);
        }

        public void DeleteOtherStructure(OtherStructure otherStructure)
        {
            _otherstructure.Delete(otherStructure);
        }

        public OtherStructure GetByID(int id)
        {
            return _otherstructure.GetByID(id);
        }

        public List<OtherStructure> GetList(int id)
        {
            return _otherstructure.GetListAll(x => x.OtherStructureId == id);
           
        }

        public List<OtherStructure> GetList()
        {
            throw new NotImplementedException();
        }

        public List<OtherStructure> GetListByCompany()
        {
            return _otherstructure.GetListByCompany();
        }

        public void UpdateOtherStructure(OtherStructure otherStructure)
        {
            _otherstructure.Update(otherStructure);
        }
    }
}
