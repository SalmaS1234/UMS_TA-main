using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepo : Repo, IRepo_1<Token, string, Token>
    {

        /* public void Create(Token obj)
         {
             *//* db.Tokens.Add(obj);
              if (db.SaveChanges() > 0) return obj;
              return null;*//*
             db.Tokens.Add(obj);
             db.SaveChanges();
         }

         public bool Delete(string id)
         {
             throw new NotImplementedException();
         }

         public List<Token> Show()
         {
             throw new NotImplementedException();
         }

         public Token Show(string id)
         {
             return db.Tokens.FirstOrDefault(t => t.TKey.Equals(id));
         }

         public Token Update(Token obj)
         {

             var token = Show(obj.TKey);
             db.Entry(token).CurrentValues.SetValues(obj);
             if (db.SaveChanges() > 0) return token;
             return null;
         }*/
        /*  public void Create(Token obj)
          {
              db.Tokens.Add(obj);
              db.SaveChanges();
          }

          public bool Delete(string id)
          {
              throw new NotImplementedException();
          }

          public List<Token> Show()
          {
              throw new NotImplementedException();
          }

          public Token Show(string id)
          {
              throw new NotImplementedException();
          }

          public bool Update(Token obj)
          {
              throw new NotImplementedException();
          }*/
        public Token Create(Token obj)
        {

             db.Tokens.Add(obj);
              if (db.SaveChanges() > 0) return obj;
            return null; 
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Show()
        {
            throw new NotImplementedException();
        }

        public Token Show(string id)
        {
            return db.Tokens.FirstOrDefault(t => t.TKey.Equals(id));
        }

        public Token Update(Token obj)
        {
            var token = Show(obj.TKey);
            db.Entry(token).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return token;
            return null;
        }
    }
}
