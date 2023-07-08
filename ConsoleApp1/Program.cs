using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)  
        {
            Console.Write("Enter Your Name");
            string vimal = Console.ReadLine();
            Console.WriteLine("Welcome to website, you are welcome, Mr." + vimal);

            Console.WriteLine("How many candies do you want?");
            string can = Console.ReadLine();
            Console.WriteLine("You will be getting 4 more candies" + (Convert.ToInt32(can) + 4));



            //int xyz = (int) 34.50;
            //Console.WriteLine(xyz);

            //int v = 4;
            //double l = v;
            //int a = 34;
            //double b = 34.4;
            //bool isGreat = true;
            //Console.WriteLine(a + b);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(b);
            // string inp = Console.ReadLine();
            // Console.WriteLine(inp);
            //int vimal = 1992; //integer variables
            /*
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello Vimal" + "" + vimal);
            Console.WriteLine("I love C++");
            */
            Console.ReadLine();
        }
    }
}
