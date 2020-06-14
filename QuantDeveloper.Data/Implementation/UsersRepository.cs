using Microsoft.EntityFrameworkCore;
using QuantDeveloper.Data.Interfaces;
using QuantDeveloper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantDeveloper.Data.Implementation
{
    public class UsersRepository : RepositoryBase<Users>, IUsersRepository
    {
        public UsersRepository(TectoroContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public Users GetUserByUserId(int id)
        {
            return this.RepositoryContext.Users.Where(x => x.UserId == id).AsNoTracking().FirstOrDefault();
        }
    }
}