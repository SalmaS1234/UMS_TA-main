using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PlanItemRepo : Repo, IRepo<PlanItem, int, bool>
    {
        public void Create(PlanItem obj)
        {
            db.PlanItems.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.PlanItems.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<PlanItem> Show()
        {
            return db.PlanItems.ToList();

        }

        public PlanItem Show(int id)
        {
            return db.PlanItems.Find(id);
        }

        public bool Update(PlanItem obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
