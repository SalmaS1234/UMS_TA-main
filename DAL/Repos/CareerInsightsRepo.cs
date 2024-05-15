using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CareerInsightsRepo : Repo, IRepo<CareerInsights, int, bool>
    {
        public void Create(CareerInsights obj)
        {
            db.CareerInsights.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.CareerInsights.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<CareerInsights> Show()
        {
            return db.CareerInsights.ToList();
        }

        public CareerInsights Show(int id)
        {
            return db.CareerInsights.Find(id);
        }

        public bool Update(CareerInsights obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
