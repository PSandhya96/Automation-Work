using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject3
{
    public class Volume
    {
        public double VolumeOfCylinder(double radius, double height)
        {
            return Math.PI * radius * radius * height;
        }

        public static double VolumeOfCuboid(double length, double width, double height)
        {
            return length * width * height;
        }

        public double VolumeOfHemisphere(double radius)
        {
            return (Math.PI * radius * radius * 2) / 3;

            string name = Volume.GetSingerName();
            Console.WriteLine(name);

            Console.WriteLine(Volume.GetSingerName());

            Console.WriteLine(Math.Max(10, 10));

            Console.WriteLine(Math.Min(10, 9));

            Console.WriteLine(Math.Pow(10, 45));

            double resPow=Math.Pow(4, 2);
            Console.WriteLine(resPow);



        }

        public static string GetSingerName()
        {
            return "Sandhya P";
        }
        public string GetGreetings()
        {
            return "Hello";
        }
    }
}
