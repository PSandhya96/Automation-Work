using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DayOneTask
{
    internal class Program
    {

        public static void calculateVolumeOfSphere(double radiusValue)
        {

            double pieValue = Math.PI;

            System.Console.WriteLine(pieValue);

            double cubeRootValue = radiusValue * radiusValue * radiusValue;

            System.Console.WriteLine(cubeRootValue);

            double volumeOfSphere = (4 * pieValue * cubeRootValue) / 3;

            System.Console.WriteLine("Volume of Sphere is :" + volumeOfSphere);
        }

        public static void Main(string[] args)
        {
            double radiusValue = 10;

            calculateVolumeOfSphere(radiusValue);

            double volumeofhemisphere = (2 * 3.14 * radiusValue * radiusValue * radiusValue) / 3;
            System.Console.WriteLine("volumeofhemisphere " + volumeofhemisphere);
            //volume of cylinder
           
            double rad1 =10;
            double height = 20;
              

        }
    }
}
