using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> miPila = new MyStack<int>();

            miPila.Push(5);
            miPila.Push(6);

            Console.WriteLine(miPila.Peek());
            //Console.WriteLine(miPila.Pop());
            //Console.WriteLine(miPila.Peek());

            foreach(var x in miPila.GetArray())
            {
                Console.Write(x + " ");
            }

            Console.ReadKey();
        }
    }
}
