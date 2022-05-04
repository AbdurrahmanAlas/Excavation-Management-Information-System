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
    public class PunishmentManager : IPunishmentService
    {
        ICezaDal _cezaDal;

        public PunishmentManager(ICezaDal cezaDal)
        {
            _cezaDal = cezaDal;
        }

        public void CezaAdd(Punishment ceza)
        {
            _cezaDal.Insert(ceza);
        }

        public void CezaDelete(Punishment ceza)
        {
            _cezaDal.Delete(ceza);
        }

        public void CezaUpdate(Punishment ceza)
        {
            _cezaDal.Update(ceza);
        }

        public Punishment GetById(int id)
        {
            return _cezaDal.GetByID(id);
        }
        public List<Punishment> GetCezaByID(int id)
        {

            return _cezaDal.GetListAll(x => x.CezaId == id);



        }

        public List<Punishment> GetList(int id)
        {
            return _cezaDal.GetListAll(x=>x.CompanyId==id);
        }

        public List<Punishment> GetPunishmentListWithCompany()
        {
            return _cezaDal.GetListWithCompany();
        }

        public List<Punishment> GetPunishmentListWithVehicle()
        {
            return _cezaDal.GetListWithVehicle();
        }
    }
}
