using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string username, string password)
        {
            var res= DataAccessFactory.AuthData().Authenticate(username, password);
            if (res)
            {
                var token = new Token();
                token.UserID=username;
                token.CreatedAT = DateTime.Now;
                token.TKey = Guid.NewGuid().ToString();
                var ret =DataAccessFactory.TokenData().Create(token);
                if(ret != null)
                {

                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(config);
                    return mapper.Map<TokenDTO>(ret);
                }

            }
            return null;
        }
    }
}
