using STO_Test.Model.Models;

namespace STO_Test.Model
{
    public class Work
    {
        public string Name { get; set; }
        public WorkType Type { get; set; }
        public decimal Cost { get; set; }
        public double DurationHours { get; set; }

        public bool IsComplete
        {
            get => default(int);
            set
            {
            }
        }
    }
}