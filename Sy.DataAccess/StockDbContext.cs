using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Sy.Core.Entities;

namespace Sy.DataAccess 
{
    public class StockDbContext : DbContext
    {
        public StockDbContext()
            : base("name = MyCon")
        {

        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
