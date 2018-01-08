using System.Drawing;

namespace AbstractFactoryExample.Figure
{
    class CircleRed : ICircle
    {
        private readonly Color circleColor = Color.Red;
        private int radius;
        
        public CircleRed()
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
            if(radius > 0)
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
