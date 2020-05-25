using System.Collections.Generic;

namespace STO_Test.Model
{
    public class Car
    {
        public string Owner { get; set; }
        public string CarModel { get; set; }
        public string CarNumber { get; set; } //Гос номер регистрации

        public List<Work> Works { get; set; } //Список работ над автомобилем
    }
}