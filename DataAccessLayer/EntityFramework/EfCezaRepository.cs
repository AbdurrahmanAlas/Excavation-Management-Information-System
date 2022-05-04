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
    public class EfCezaRepository : GenericRepository<Punishment>, ICezaDal
    {
        public List<Punishment> GetListWithCompany()
        {
           using(var c=new Context())
            {

                return c.Punishments.Include(x => x.Company).ToList();


            }
        }

        public List<Punishment> GetListWithVehicle()
        {
            using (var c = new Context())
            {
                return c.Punishments.Include(x => x.Arac).ToList();
            }
        }
    }
}
