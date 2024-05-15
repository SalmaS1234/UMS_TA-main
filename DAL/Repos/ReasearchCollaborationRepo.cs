using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ReasearchCollaborationRepo : Repo, IRepo<ReasearchCollaboration, int, bool>
    {
        public void Create(ReasearchCollaboration obj)
        {
            db.ReasearchCollaborations.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.ReasearchCollaborations.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<ReasearchCollaboration> Show()
        {
            return db.ReasearchCollaborations.ToList();
        }

        public ReasearchCollaboration Show(int id)
        {
            return db.ReasearchCollaborations.Find(id);
        }

        public bool Update(ReasearchCollaboration obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
