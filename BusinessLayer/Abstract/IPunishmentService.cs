using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IPunishmentService

    {
        void CezaAdd(Punishment ceza);
        void CezaDelete(Punishment ceza);
        void CezaUpdate(Punishment ceza);
        List<Punishment> GetList(int id);
        Punishment GetById(int id);

        List<Punishment> GetPunishmentListWithVehicle();
        List<Punishment> GetPunishmentListWithCompany();


    }
}
