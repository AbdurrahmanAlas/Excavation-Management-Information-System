using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=DESKTOP-EM6EPAC; database=VTHYBS;integrated security=true;");



        }

        public DbSet<Punishment> Punishments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Filling> Fillings { get; set; }
        public DbSet<OtherStructure> OtherStructures { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AltyapıIsler> AltyapıIslers { get; set; }
        public DbSet<SmallVehicle> SmallVehicles { get; set; }

        public DbSet<BalanceSmall> BalanceSmalls { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<CompanyDocument> CompanyDocuments { get; set; }
        public DbSet<CompanyBalance> CompanyBalances { get; set; }




    }
}
