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
    public class EfFillingRepository : GenericRepository<Filling>, IFillingDal
    {
        public List<Filling> GetFillingByCompany()
        {
            using (var c = new Context())
            {


                return  c.Fillings.Include(x => x.Company).ToList();
               
                    }
           
        }
    }
}
