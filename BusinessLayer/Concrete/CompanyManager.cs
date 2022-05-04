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
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;


        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void CompanyAdd(Company company)
        {
            _companyDal.Insert(company);

        }

        public void CompanyDelete(Company company)
        {
            _companyDal.Delete(company);
        }

        public void CompanyDocumentAdd(Company company)
        {
            _companyDal.Insert(company);
        }

        public void CompanyUpdate(Company company)
        {
            _companyDal.Update(company);
        }

        public Company GetById(int id)
        {
            return _companyDal.GetByID(id);
        }

        public List<Company> GetCompanyByID(int id)
        {

            return _companyDal.GetListAll(x => x.CompanyId == id);

        }

       

        public List<Company> GetList()
        {
            return _companyDal.GetListAll();
        }

        public List<Company> GetListDocument(int id)
        {
            return _companyDal.GetListAll(x => x.CompanyId == id);
        }
    }
}
