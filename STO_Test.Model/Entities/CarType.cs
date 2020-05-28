using System.Collections.Generic;

namespace STO_Test.Model.Entities
{
    public class CarType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public List<WorkType> AviableWorkTypes { get; set; }
    }
}
