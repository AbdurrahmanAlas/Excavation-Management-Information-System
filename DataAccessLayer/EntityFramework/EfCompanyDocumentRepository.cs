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
    public class EfCompanyDocumentRepository : GenericRepository<CompanyDocument>, ICompanyDocumentDal
    {
        public List<CompanyDocument> GetListWithCompany()
        {
            using (var c = new Context())
            {

                return c.CompanyDocuments.Include(x => x.Company).ToList();
            }
        }
    }
}
