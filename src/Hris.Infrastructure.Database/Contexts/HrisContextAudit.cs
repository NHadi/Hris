using Hris.Common.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hris.Infrastructure.Database.Contexts
{
    public partial class HrisContext : DbContext    
    {
        public override int SaveChanges()
        {
            Audit();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            Audit();
            return await base.SaveChangesAsync();
        }

        private void Audit()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is EntityBase && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((EntityBase)entry.Entity).CreatedDate = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    ((EntityBase)entry.Entity).ModifyDate = DateTime.Now;
                }            
            }
        }
    }
}
