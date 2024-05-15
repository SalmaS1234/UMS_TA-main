using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AddRequestPaperPublishRepo : Repo, IRepo<AddRequestPaperPublish, int, bool>
    {
        public void Create(AddRequestPaperPublish obj)
        {
            db.addRequestPaperPublishes.Add(obj);
        }

        public bool Delete(int id)
        {
            var exobj=Show(id);
            db.addRequestPaperPublishes.Remove(exobj);
            return db.SaveChanges() > 0;

        }

        public List<AddRequestPaperPublish> Show()
        {
           return db.addRequestPaperPublishes.ToList();
        }

        public AddRequestPaperPublish Show(int id)
        {
            return db.addRequestPaperPublishes.Find(id);
        }

        public bool Update(AddRequestPaperPublish obj)
        {
            var exobj=Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(exobj);
             return db.SaveChanges()>0;
        }
    }
}
