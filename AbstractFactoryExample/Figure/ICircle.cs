using System.Drawing;

namespace AbstractFactoryExample.Figure
{
    interface ICircle
    {
        int GetRadius();
        bool SetRadius(int radius);
        Color GetCirleColor();
    }
}
