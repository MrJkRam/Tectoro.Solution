using QuantDeveloper.Business.Interfaces;
using QuantDeveloper.Business.Models;
using QuantDeveloper.Data.Implementation;
using QuantDeveloper.Data.Interfaces;
using QuantDeveloper.Data.Models;
using Remotion.Linq.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace QuantDeveloper.Business
{
    public class UsersService : IUsersService
    {
        private readonly IRepositoryFactory _factory;
        private readonly IUsersRepository _user;

        public UsersService(IRepositoryFactory factory, IUsersRepository usersRepository)
        {
            _factory = factory;
            _user = usersRepository;
        }

        public void Create(User entity)
        {
            _user.Create(entity.MapToEntity());
            _factory.Save();
        }

        public void Delete(User entity)
        {
            _user.Delete(entity.MapToEntity());
            _factory.Save();
        }

        public IQueryable<User> FindAll()
        {
            List<User> users = new List<User>();
            var _users = _user.FindAll();

            if (_users != null)
            {

                foreach (var item in _users)
                {
                    users.Add(item.MapToDto());
                }
            }
            return users.AsQueryable();
        }

        public IQueryable<User> FindByCondition(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUserId(int id)
        {
            var user = _user.GetUserByUserId(id);
            if (user != null)
            {
                return user.MapToDto();
            }
            return null;
        }

        public void Update(User entity)
        {
            _user.Update(entity.MapToEntity());
            _factory.Save();
        }
    }
}
