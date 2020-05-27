using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STO_Test.Model.Entities;

namespace STO_Test.Model.Abstract
{
    interface IWork
    {
        List<EmployeeType> EmployeesAvailable { get; set; }
        List<CarType> CarsAvailable { get; set; }

        void AddEmployee();
    }
}
