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
    public class CompanyBalanceManager : ICompanyBalanceService
    {
        ICompanyBalanceDal _companyBalanceDal;

        public CompanyBalanceManager(ICompanyBalanceDal companyBalanceDal)
        {
            _companyBalanceDal = companyBalanceDal;
        }

        public List<CompanyBalance> GetBalanceWithCompany()
        {
            return _companyBalanceDal.GetListWithCompany();
        }

        public List<CompanyBalance> GetList()
        {
           return _companyBalanceDal.GetListAll();
        }

        public void TAdd(CompanyBalance t)
        {
            _companyBalanceDal.Insert(t);
        }

        public void TDelete(CompanyBalance t)
        {
            _companyBalanceDal.Delete(t);
        }

        public CompanyBalance TGetById(int id)
        {
           return _companyBalanceDal.GetByID(id);
        }

        public void TUpdate(CompanyBalance t)
        {
            _companyBalanceDal.Update(t);
        }
    }
}
