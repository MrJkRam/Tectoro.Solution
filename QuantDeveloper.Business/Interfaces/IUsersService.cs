using QuantDeveloper.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace QuantDeveloper.Business.Interfaces
{
    public interface IUsersService
    {
        IQueryable<User> FindAll();
        IQueryable<User> FindByCondition(Expression<Func<User, bool>> expression);
        void Create(User entity);
        void Update(User entity);
        void Delete(User entity);

        User GetUserByUserId(int id);
    }
}
