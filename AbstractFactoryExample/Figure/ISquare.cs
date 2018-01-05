using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.Figure
{
    interface ISquare
    {
        int GetSideSize();
        bool SetSideSize(int sideSize);
        Color GetSqureColor();
    }
}
