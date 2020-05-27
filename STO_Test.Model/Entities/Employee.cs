using System.Collections.Generic;

namespace STO_Test.Model.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EmployeeType Type { get; set; }
        public List<Work> Works { get; set; } //Список работ, на которые назначен сотрудник
    }
}
