using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using STO_Test.Model.Entities;

namespace STO_Test.Model.Abstract
{
    public interface ICar
    {
        void AddWork(Work work);
    }
}