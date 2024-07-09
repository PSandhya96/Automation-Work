using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject_4
{
    public class Runner2
    {
        public static int aS = 10;
        public static int bS = 20;

        public int aNS = 10;
        public int bNS = 20;

        public static void Main(string[] args)
        {
            int a = 10; //32 bits 
            Console.WriteLine(aS);

            Runner2.aS = 1000;
            Console.WriteLine(Runner2.aS);
            Console.WriteLine(Runner2.bS);

            Runner2 obj1 = new Runner2();
            obj1.aNS = 1000;


            Console.WriteLine(obj1.aNS);
            Console.WriteLine(obj1.bNS);
        }
    }
}
