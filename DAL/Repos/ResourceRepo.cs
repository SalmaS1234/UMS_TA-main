using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ResourceRepo : Repo, IRepo<Resource, int, bool>
    {
        public void Create(Resource obj)
        {
            db.Resources.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.Resources.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Resource> Show()
        {
            return db.Resources.ToList();

        }

        public Resource Show(int id)
        {
            return db.Resources.Find(id);

        }

        public bool Update(Resource obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
