using System.Collections.Generic;

namespace STO_Test.Model.Entities
{
    public class Work
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DurationHours { get; set; }
        public bool IsComplete { get; set; }

        public WorkType Type { get; set; }
        public List<Employee> Employees { get; set; }
    }
}