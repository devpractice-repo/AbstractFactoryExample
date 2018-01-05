using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryExample.Figure;

namespace AbstractFactoryExample.Factory
{
    class ConcreteFactoryGreen : IAbstractFactory
    {
        public ConcreteFactoryGreen()
        {

        }

        #region IAbstractFactory interface
        public ICircle CreateCircle()
        {
            return new Figure.CircleGreen();
        }

        public ISquare CreateSquare()
        {
            return new Figure.SquareGreen();
        }
        #endregion IAbstractFactory interface
    }
}
