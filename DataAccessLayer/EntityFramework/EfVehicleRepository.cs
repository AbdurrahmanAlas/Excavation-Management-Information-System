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
    public class EfVehicleRepository : GenericRepository<Vehicle>, IVehicleDal
    {
        public List<Vehicle> GetListWithCompany()
        {
            using(var c=new Context())
            {
                return c.Vehicles.Include(x => x.Company).ToList();
            }
        }
    }
}
