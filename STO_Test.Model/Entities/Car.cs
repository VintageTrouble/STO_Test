using System.Collections.Generic;

namespace STO_Test.Model.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public CarType CarType { get; set; } //Грузовик, легковая и тд...
        public string Owner { get; set; }
        public string CarNumber { get; set; } //Гос номер регистрации

        public List<Work> Works { get; set; } //Список работ над автомобилем
        public List<Employee> Workers { get; set; } //Список сотрудников, работающих с авто
    }
}