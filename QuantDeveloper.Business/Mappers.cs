using QuantDeveloper.Business.Models;
using QuantDeveloper.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantDeveloper.Business
{
    public static class Mappers
    {
        public static User MapToDto(this Users entity)
        {
            return new User()
            {
                UserId = entity.UserId,
                UserName = entity.UserName,
                Email = entity.Email,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Alias = entity.Alias
            };

        }

        public static Users MapToEntity(this User entity)
        {
            return new Users()
            {
                UserId = entity.UserId,
                UserName = entity.UserName,
                Email = entity.Email,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Alias = entity.Alias
            };

        }
    }
}
