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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _contentDal.GetListAll(x => x.HeadingID == id);
        }

        public void TAdd(Content t)
        {
            _contentDal.Insert(t);
        }

        public void TDelete(Content t)
        {
            throw new NotImplementedException();
        }

        public Content TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Content t)
        {
            throw new NotImplementedException();
        }
    }
}
