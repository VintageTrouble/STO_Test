using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using STO_Test.Model.Cars;
using STO_Test.Model.Employees;
using STO_Test.Model.Entities;

namespace STO_Test.Model.Works
{
    public abstract class BaseWork : Work
    {
        public virtual List<BaseCar> CarAvailable { get; set; }
        public virtual List<BaseEmployee> EmployeeAvailable { get; set; }

        //Future functionality
    }
}