using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject3
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            Volume vikram = new Volume();
           
            double result= vikram.VolumeOfCylinder(10, 3);
            Console.WriteLine(result);

            double result1 = Volume.VolumeOfCuboid(10, 3, 2);
            Console.WriteLine(result1);
            double result2 = vikram.VolumeOfHemisphere(10);
            Console.WriteLine(result2);

            Console.WriteLine(Math.Max(12, 8));
            Console.WriteLine (Math.Min(10, 9));
            double respwr = Math.Pow(10, 12);
            Console.WriteLine(Math.Pow(2, 5));

            Console.WriteLine(vikram.GetGreetings());
            Console.WriteLine(Volume.GetSingerName());


        }
    }
}
