using QuantDeveloper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace QuantDeveloper.Data.Interfaces
{
    public interface IUsersRepository : IRepositoryBase<Users>
    {
        Users GetUserByUserId(int id);
    }
}