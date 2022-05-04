using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IStructureService
    {
        void StructureAdd(Structure structure);
        void StructureDelete(Structure structure);
        void StructureUpdate(Structure structure);
        List<Structure> GetList();
        Structure GetById(int id);

        List<Structure> GetListDocument(int id);
        List<Structure> GetStructureListCompany();

    }
}
