using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCompanyBalanceRepository : GenericRepository<CompanyBalance>, ICompanyBalanceDal
    {
        public List<CompanyBalance> GetListWithCompany()
        {
            using (var c = new Context())
            {

                return c.CompanyBalances.Include(x => x.Company).ToList();


            }
        }
    }
}
