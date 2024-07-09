using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kpmg.Area.Formulae {

public class Area
{
    public static double AreaofCircle(int r)
    {
        return Math.PI * r * r;
    }

    public static double AreaofRectangle(double length, double width)
    {
        return length * width; 
    }

    public static double AreaofSquare(double square)

    {
        return square * square;
    }
}
}
