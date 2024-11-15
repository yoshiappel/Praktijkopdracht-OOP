using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Praktijk_Opdracht_OOP
{
    public class Shape
    {
        // Variables
        private Color color { get; set; }
        public double Height;

        private double _width;
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }



        // Constructor
        public Shape(double Width = 0, double Height = 0)
        {
            this.Width = Width;
            this.Height = Height;
        }
    }
}
