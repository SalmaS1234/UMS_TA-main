﻿using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SubmissionRepo : Repo, IRepo<Submission, int, bool>
    {
        public void Create(Submission obj)
        {

            db.Submissions.Add(obj);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var exobj = Show(id);
            db.Submissions.Remove(exobj);
            return db.SaveChanges() > 0;
        }

        public List<Submission> Show()
        {
            return db.Submissions.ToList();

        }

        public Submission Show(int id)
        {
            return db.Submissions.Find(id);

        }

        public bool Update(Submission obj)
        {
            var exobj = Show(obj.ID);
            db.Entry(exobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}