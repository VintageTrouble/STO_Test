using System.Collections.Generic;
using STO_Test.Model.Abstract;
using STO_Test.Model.Entities;

namespace STO_Test.Model.Concrete.Works
{
    public class EngineCheck : Work, IWork
    {
        public List<EmployeeType> EmployeesAvailable { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public List<CarType> CarsAvailable { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void AddEmployee()
        {
            throw new System.NotImplementedException();
        }

        //Future functionality

    }
}