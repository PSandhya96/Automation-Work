using kpmg.Area.Formulae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsHARPpROJECT2
{
    public class Program
    {
        public static double AreaofCircle(int r)
        {
            return Math.PI * r * r;
        }
        public static double AreaofRectangle(double length, double width)
        {
            return length * width;

        }
        public static void Main()
        {

            int radius = 10;

           
            double Vikram = Area.AreaofRectangle(radius, 10.2);

            double result = AreaofCircle(radius);

            Console.WriteLine(result);

            Console.WriteLine(Vikram);

            Console.WriteLine(result);

        }
    }
}
