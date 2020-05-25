using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STO_Test.Model.Models;

namespace STO_Test.Model.Db
{
    class STOContext : DbContext
    {
        public STOContext() 
            : base("DbConnection")
        {}

        public DbSet<Work> Works { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
