using Microsoft.EntityFrameworkCore.Storage;
using StarWarsDatabank.Framework.DataFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.FFG.Data.Infrastructure
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly FFGDatabankContext _context;
        private IDbContextTransaction? Transaction { get; set; }



        public EFUnitOfWork(FFGDatabankContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            Transaction = _context.Database.BeginTransaction();
        }

        public void Commit() => Transaction?.Commit();

        public void Rollback() => Transaction?.Rollback();
    }
}
