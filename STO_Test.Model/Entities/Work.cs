namespace STO_Test.Model.Entities
{
    public class Work
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WorkType Type { get; set; }
        public decimal Cost { get; set; }
        public double DurationHours { get; set; }
        public bool IsComplete { get; set; }
    }
}