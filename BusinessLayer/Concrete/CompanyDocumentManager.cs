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
    public class CompanyDocumentManager : ICompanyDocumentService

    {
        ICompanyDocumentDal _companydocumentdal;

        public CompanyDocumentManager(ICompanyDocumentDal companydocumentdal)
        {
            _companydocumentdal = companydocumentdal;
        }

        public List<CompanyDocument> GetList(int id)
        {
            return _companydocumentdal.GetListAll(x=>x.CompanyId==id);
        }

        public List<CompanyDocument> GetList()
        {
            throw new NotImplementedException();
        }

        public List<CompanyDocument> GetDocumentWithCompany()
        {
            return _companydocumentdal.GetListWithCompany();
        }

        public void TAdd(CompanyDocument t)
        {
            _companydocumentdal.Insert(t);
        }

        public void TDelete(CompanyDocument t)
        {
            _companydocumentdal.Delete(t);
        }

        public CompanyDocument TGetById(int id)
        {
            return _companydocumentdal.GetByID(id);
        }

        public void TUpdate(CompanyDocument t)
        {
            throw new NotImplementedException();
        }
    }
}
