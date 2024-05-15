using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PaperPublishListRepo : Repo, IRepo<PaperPublishList, int, bool>
    {
        public void Create(PaperPublishList obj)
        {
            db.paperPublishLists.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj =Show(id);
            db.paperPublishLists.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<PaperPublishList> Show()
        {
            return db.paperPublishLists.ToList();
        }

        public PaperPublishList Show(int id)
        {
            return db.paperPublishLists.Find(id);
        }

        public bool Update(PaperPublishList obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
