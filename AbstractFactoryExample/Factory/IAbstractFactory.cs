using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExample.Figure;

namespace AbstractFactoryExample.Factory
{
    interface IAbstractFactory
    {
        ISquare CreateSquare();
        ICircle CreateCircle();        
    }
}
