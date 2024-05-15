using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class InternshipPublishListRepo : Repo, IRepo<InternshipPublishList, int, bool>
    {
        public void Create(InternshipPublishList obj)
        {
            db.internshipPublishLists.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.internshipPublishLists.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<InternshipPublishList> Show()
        {
            return db.internshipPublishLists.ToList();
        }

        public InternshipPublishList Show(int id)
        {
            return db.internshipPublishLists.Find(id);
        }

        public bool Update(InternshipPublishList obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
