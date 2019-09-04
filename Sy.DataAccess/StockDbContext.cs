using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Sy.Core.Entities;
using Sy.Core.ComplexType;
using Sy.Core.Abstracts;

namespace Sy.DataAccess 
{
    public class StockDbContext : DbContext
    {
        public StockDbContext()
            : base("name = MyCon")
        {
     
        }
        public override int SaveChanges()
        {
            //Audit işlemleri
            if (StockSettings.UserInfo != null)
            {
                var selectedEntryList = ChangeTracker.Entries()
                    .Where(x => x.Entity is AuditBase && x.State == EntityState.Added);
                foreach (var item in selectedEntryList)
                {
                    ((AuditBase)item.Entity as AuditBase).CreatedUser = StockSettings.UserInfo.Email;
                    ((AuditBase) item.Entity).CreateDate = DateTime.Now;

                }
                selectedEntryList = ChangeTracker.Entries()
                    .Where(x => x.Entity is AuditBase && x.State == EntityState.Modified);
                foreach (var item in selectedEntryList)
                {
                    ((AuditBase)item.Entity as AuditBase).UpdateUser = StockSettings.UserInfo.Email;
                    ((AuditBase)item.Entity).UpdatedDate = DateTime.Now;

                }

            }

            return base.SaveChanges();
        }


        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Client> Clients { get; set; }



    }
}
