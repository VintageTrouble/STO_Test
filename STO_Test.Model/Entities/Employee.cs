using System.Collections.Generic;

namespace STO_Test.Model.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBusy { get; set; }

        public virtual EmployeeType Type { get; set; }
        public virtual List<Work> Works { get; set; } //Список работ, на которые назначен сотрудник
    }
}
