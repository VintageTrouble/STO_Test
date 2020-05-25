using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STO_Test.Model.Entities;


namespace STO_Test.Model.Db
{
    public class STOContext : DbContext
    {
        public STOContext() 
            : base("DbConnection")
        {}

        public DbSet<Work> Works { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
    }
}
