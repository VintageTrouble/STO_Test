using STO_Test.Model.Abstract;
using STO_Test.Model.Entities;

namespace STO_Test.Model.Concrete.Cars
{
    public class MinivanCar : Car, ICar
    {
        public void AddWork(Work work)
        {
            throw new System.NotImplementedException();
        }

        //Future functionality

    }
}