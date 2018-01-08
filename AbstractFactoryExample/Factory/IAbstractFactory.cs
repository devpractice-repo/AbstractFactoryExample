using AbstractFactoryExample.Figure;

namespace AbstractFactoryExample.Factory
{
    interface IAbstractFactory
    {
        ISquare CreateSquare();
        ICircle CreateCircle();        
    }
}
