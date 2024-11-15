using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktijk_Opdracht_OOP
{
    public class Rectangle : Shape
    {
        public Rectangle(double Width = 0, double Height = 0) : base(Width, Height)
        {
            
        }

        public int berekenOppervlakte(int Oppervlakte)
        {
            return Oppervlakte;
        }
    }
}
