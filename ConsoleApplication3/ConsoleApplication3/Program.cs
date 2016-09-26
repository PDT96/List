using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Element<int> a= new Element<int>(4);
            Element<int> c = new Element<int>(5);
            List<int> list = new List<int>();
            list.AddFirst(a);
            list.AddFirst(c);
            list.PrintList();
            Console.ReadKey();




        }
    }
}
