using System.Drawing;

namespace AbstractFactoryExample.Figure
{
    class CircleGreen : ICircle
    {
        private readonly Color circleColor = Color.Green;
        private int radius;

        public CircleGreen()
        {
            radius = 25;
        }

        #region ICircle interface
        public Color GetCirleColor()
        {
            return circleColor;
        }

        public int GetRadius()
        {
            return radius;
        }

        public bool SetRadius(int radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion ICircle interface
    }
}
