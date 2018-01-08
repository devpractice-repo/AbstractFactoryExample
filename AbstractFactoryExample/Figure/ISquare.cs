using System.Drawing;

namespace AbstractFactoryExample.Figure
{
    interface ISquare
    {
        int GetSideSize();
        bool SetSideSize(int sideSize);
        Color GetSqureColor();
    }
}
