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
    public class EfSmallBalanceRepository : GenericRepository<BalanceSmall>, ISmallBalanceDal
    {
        public List<BalanceSmall> GetListWithSmallVehicle()
        {
            using (var c = new Context())
            {

                return c.BalanceSmalls.Include(x => x.SmallVehicle).ToList();
            }
        }
    }
}
