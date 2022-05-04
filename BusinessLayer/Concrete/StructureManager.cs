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
    public class StructureManager : IStructureService
    {
        IStructureDal _structureDal;

        public StructureManager(IStructureDal structureDal)
        {
            _structureDal = structureDal;
        }

        public Structure GetById(int id)
        {
            return _structureDal.GetByID(id);
        }

        public List<Structure> GetList()
        {
            return _structureDal.GetListAll();
        }

        public List<Structure> GetListDocument(int id)
        {
            return _structureDal.GetListAll(x => x.CompanyId == id);
        }

        public List<Structure> GetStructureListCompany()
        {
            return _structureDal.GetListWithCompany();
        }

        public void StructureAdd(Structure structure)
        {
            _structureDal.Insert(structure);
        }

        public void StructureDelete(Structure structure)
        {
            _structureDal.Delete(structure);
        }

        public void StructureUpdate(Structure structure)
        {
            _structureDal.Update(structure);
        }
    }
}
