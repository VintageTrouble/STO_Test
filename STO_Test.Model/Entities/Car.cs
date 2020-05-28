using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using STO_Test.Model.Abstract;

namespace STO_Test.Model.Entities
{
    public class Car
    {
        public int Id { get; set; }
        [ForeignKey("CarType")] public int CarTypeId { get; set; }
        public string Owner { get; set; }
        public string StateNumber { get; set; } //Гос номер регистрации

        //Навигационные свойства
        public virtual CarType CarType { get; set; } //Тип кузова
        public virtual List<Work> Works { get; set; } //Список работ над автомобилем
    }
}