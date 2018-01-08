using AbstractFactoryExample.Figure;

namespace AbstractFactoryExample.Factory
{
    class ConcreteFactoryRed : IAbstractFactory
    {
        public ConcreteFactoryRed()
        {

        }

        #region IAbstractFactory interface
        public ICircle CreateCircle()
        {
            return new Figure.CircleRed();
        }

        public ISquare CreateSquare()
        {
            return new Figure.SquareRed();
        }
        #endregion IAbstractFactory interface
    }
}
