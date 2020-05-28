using System.Collections.Generic;

namespace STO_Test.Model.Entities
{
    public class WorkType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public List<CarType> AvailableCarTypes { get; set; }
        public List<EmployeeType> AvailableEmployeeTypes { get; set; }
    }
}
