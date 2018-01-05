﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.Figure
{
    class SquareGreen : ISquare
    {
        private int sideSize;
        private readonly Color color = Color.Green;

        public SquareGreen()
        {
            sideSize = 50;
        }

        #region ISquare interface
        public int GetSideSize()
        {
            return sideSize;
        }

        public Color GetSqureColor()
        {
            return color;
        }

        public bool SetSideSize(int sideSize)
        {
            if (sideSize > 0)
            {
                this.sideSize = sideSize;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion ISquare interface
    }
}
