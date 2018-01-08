using System;
using System.Drawing;
using System.Windows.Forms;
using AbstractFactoryExample.Factory;

namespace AbstractFactoryExample
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private IAbstractFactory factoryRed;
        private IAbstractFactory factoryGreen;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFigType.SelectedIndex = 0;

            g = this.CreateGraphics();
            factoryRed = new ConcreteFactoryRed();
            factoryGreen = new ConcreteFactoryGreen();
        }

        private void tbBuild_Click(object sender, EventArgs e)
        {
            switch(cbFigType.SelectedItem)
            {
                case "Red": DrawFigure(factoryRed);
                    break;
                case "Green": DrawFigure(factoryGreen);
                    break;
            }
        }

        private void tbClear_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
        }

        private void DrawFigure(IAbstractFactory factory)
        {
            Figure.ICircle circle = factory.CreateCircle();
            Figure.ISquare square = factory.CreateSquare();

            SolidBrush brush = new SolidBrush(square.GetSqureColor());
            g.FillRectangle(brush, new Rectangle(100, 100, square.GetSideSize(), square.GetSideSize()));
            g.FillEllipse(brush, new Rectangle(250, 100, circle.GetRadius() * 2, circle.GetRadius() * 2));
            brush.Dispose();
        }
    }
}
