using System.Collections.Generic;
using STO_Test.Model.Abstract;
using STO_Test.Model.Entities;
using System.Linq;
using STO_Test.Model.Concrete.Cars;
using System;

namespace STO_Test.Model.Db
{
    public class DbHandler
    {
        #region ---Get Cars---

        /// <summary>
        /// Метод возвращает весь набор автомобилей
        /// </summary>
        /// <returns></returns>
        public List<Car> GetCars()
        {
            var db = new STOContext();
            var cars = db.Cars.ToList();

            return cars;
        }

        /// <summary>
        /// Метод возвращает список автомобилей указанного типа кузова
        /// </summary>
        /// <param name="carType">Имя типа кузова</param>
        /// <returns>Возвращает список автомобилей указанного типа</returns>
        public List<Car> GetCarsByType(string carType)
        {
            var db = new STOContext();
            var cars = db.Cars.Where(c => c.CarType.TypeName == carType).ToList();

            return cars;
        }

        /// <summary>
        /// Метод возвращает список автомобилей указанного хозяина
        /// </summary>
        /// <param name="carOwner">ФИО владельца</param>
        /// <returns></returns>
        public List<Car> GetCarsByOwner(string carOwner)
        {
            var db = new STOContext();
            var cars = db.Cars.Where(c => c.Owner == carOwner).ToList();

            return cars;
        }

        /// <summary>
        /// Метод возвращает автомобиль c указанным государственным номером
        /// </summary>
        /// <param name="stateNumber">Государственный номер автомобиля</param>
        /// <returns></returns>
        public Car GetCarByStateNumber(string stateNumber)
        {
            var db = new STOContext();
            var car = db.Cars.Where(c => c.StateNumber == stateNumber).FirstOrDefault();

            return car;
        }

        /// <summary>
        /// Метод ищет автомомобиль по ID
        /// </summary>
        /// <param name="carId">ID автомобиля</param>
        /// <returns></returns>
        public Car GetCarById(int carId)
        {
            var db = new STOContext();
            var car = db.Cars.Where(c => c.Id == carId).FirstOrDefault();

            return car;
        }

        #endregion

        #region ---Get CarTypes---

        /// <summary>
        /// Метод возвращает полный список типов кузовов, обслуживаемых данной СТО
        /// </summary>
        /// <returns></returns>
        public List<CarType> GetCarTypes()
        {
            var carTypes = new List<CarType>();
            var db = new STOContext();

            foreach (var carType in db.CarTypes)
            {
                carTypes.Add(carType);
            }
            
            return carTypes;
        }

        /// <summary>
        /// Метод возвращает тип кузова по названию
        /// </summary>
        /// <param name="carTypeName">Название типа кузова</param>
        /// <returns></returns>
        public CarType GetCarTypeByName(string carTypeName)
        {
            var db = new STOContext();
            var carType = db.CarTypes.Where(c => c.TypeName == carTypeName).FirstOrDefault();

            return carType;
        }

        /// <summary>
        /// Метод возвращает тип кузова по ID
        /// </summary>
        /// <param name="carTypeId">ID типа кузова</param>
        /// <returns></returns>
        public CarType GetCarTypeById(int carTypeId)
        {
            var db = new STOContext();
            var carType = db.CarTypes.Where(c => c.Id == carTypeId).FirstOrDefault();

            return carType;
        }

        #endregion

        #region ---Get Works---

        public List<Work> GetWorks()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ---Get WorkTypes---

        public List<WorkType> GetWorkTypes()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ---Get Employees---

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ---Get EmployeeTypes---

        public List<EmployeeType> GetAllEmployeeTypes()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ---Add Methods---

        public void AddCar(Car car)
        {
            var db = new STOContext();

            db.Cars.Add(car);
            db.SaveChanges();
        }

        public void AddWork(Work work)
        {
            var db = new STOContext();

            db.Works.Add(work);
            db.SaveChanges();
        }

        public void AddEmployee(Employee employee)
        {
            var db = new STOContext();

            db.Employees.Add(employee);
            db.SaveChanges();
        }

        #endregion

        #region ---Update Methods---

        /// <summary>
        /// Метод обновляет запись в базе автомобилей
        /// </summary>
        /// <param name="old">Запись об автомобиле к изменению</param>
        /// <param name="newCar">Измененная зпись об автомобиле</param>
        public void UpdateCar(Car old, Car newCar)
        {
            var db = new STOContext();
            var carTemp = db.Cars.Where(c => c.Id == old.Id).FirstOrDefault();

            carTemp = newCar;
            db.SaveChanges();
        }

        /// <summary>
        /// Обновляет запись в базе автомобилей по Id
        /// </summary>
        /// <param name="old">Id элемента к изменению</param>
        /// <param name="newCar">Измененная зпись об автомобиле</param>
        public void UpdateCar(int old, Car newCar)
        {
            var db = new STOContext();
            var carTemp = db.Cars.Where(c => c.Id == old).FirstOrDefault();

            carTemp = newCar;

            db.SaveChanges();
        }

        /// <summary>
        /// Метод обновляет запись в базе обслуживаемых кузовов автомобилей
        /// </summary>
        /// <param name="old">Запись о кузове автомобиля к изменению</param>
        /// <param name="newCarType">Измененная зпись об кузове автомобиля</param>
        public void UpdateCarType(CarType old, CarType newCarType)
        {
            var db = new STOContext();
            var carTemp = db.CarTypes.Where(c => c.Id == old.Id).FirstOrDefault();

            carTemp = newCarType;

            db.SaveChanges();
        }

        /// <summary>
        /// Метод обновляет запись в базе обслуживаемых кузовов автомобилей по Id
        /// </summary>
        /// <param name="old">Id элемента к изменению</param>
        /// <param name="newCarType">Измененная зпись об кузове автомобиля</param>
        public void UpdateCarType(int old, CarType newCarType)
        {
            var db = new STOContext();
            var carTemp = db.CarTypes.Where(c => c.Id == old).FirstOrDefault();

            carTemp = newCarType;

            db.SaveChanges();
        }

        #endregion

        #region ---Remove Methods---

        /// <summary>
        /// Метод удаляет запись из базы
        /// </summary>
        /// <param name="car">запись к удалению</param>
        public void RemoveCar(Car car)
        {
            var db = new STOContext();

            db.Cars.Remove(car);
            db.SaveChanges();
        }

        /// <summary>
        /// Метод удаляет запись из базы по Id
        /// </summary>
        /// <param name="carId">Id записи к удалению</param>
        public void RemoveCar(int carId)
        {
            var db = new STOContext();

            db.Cars.Remove(db.Cars.Where(c => c.Id == carId).FirstOrDefault());
            db.SaveChanges();
        }

        /// <summary>
        /// Метод удаляет запись из базы
        /// </summary>
        /// <param name="carType">запись к удалению</param>
        public void RemoveCarType(CarType carType)
        {
            var db = new STOContext();

            db.CarTypes.Remove(carType);
            db.SaveChanges();
        }

        /// <summary>
        /// Метод удаляет запись из базы по Id
        /// </summary>
        /// <param name="carId">Id записи к удалению</param>
        public void RemoveCarType(int carId)
        {
            var db = new STOContext();

            db.CarTypes.Remove(db.CarTypes.Where(c => c.Id == carId).FirstOrDefault());
            db.SaveChanges();
        }

        #endregion

        //TODO: another requests
    }
}
