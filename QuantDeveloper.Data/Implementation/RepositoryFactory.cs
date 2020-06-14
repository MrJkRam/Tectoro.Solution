using QuantDeveloper.Data.Interfaces;
using QuantDeveloper.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantDeveloper.Data.Implementation
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private TectoroContext _repoContext;

        public RepositoryFactory(TectoroContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
