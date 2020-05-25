using System.Collections.Generic;
using STO_Test.Model.Db;
using STO_Test.Model.Entities;

namespace STO_Test.Model
{
    public class DbReader
    {
        //---Variables---
        STOContext db;

        //---Methods---
        public List<Car> GetCars()
        {
            var cars = new List<Car>();

            using (db = new STOContext())
            {
                foreach (var car in db.Cars)
                {
                    cars.Add(car);
                }
            }

            return cars;
        }

        public List<CarType> GetCarTypes()
        {
            var carTypes = new List<CarType>();
            using (db = new STOContext())
            {
                foreach (var carType in db.CarTypes)
                {
                    carTypes.Add(carType);
                }
            }

            return carTypes;
        }

        public List<Work> GetWorks()
        {
            var works = new List<Work>();

            using (db = new STOContext())
            {
                foreach (var work in db.Works)
                {
                    works.Add(work);
                }
            }

            return works;
        }

        public List<WorkType> GetWorkTypes()
        {
            var workTypes = new List<WorkType>();

            using (db = new STOContext())
            {
                foreach (var workType in db.WorkTypes)
                {
                    workTypes.Add(workType);
                }
            }

            return workTypes;
        }

        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();

            using (db = new STOContext())
            {
                foreach (var employee in db.Employees)
                {
                    employees.Add(employee);
                }
            }

            return employees;
        }

        public List<EmployeeType> GetEmployeeTypes()
        {
            var employeeTypes = new List<EmployeeType>();

            using (db = new STOContext())
            {
                foreach (var employeeType in db.EmployeeTypes)
                {
                    employeeTypes.Add(employeeType);
                }
            }

            return employeeTypes;
        }
    }
}
