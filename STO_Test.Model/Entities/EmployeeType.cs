using System.Collections.Generic;

namespace STO_Test.Model.Entities
{
    public class EmployeeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public List<WorkType> AviableWorkType { get; set; }
    }
}
