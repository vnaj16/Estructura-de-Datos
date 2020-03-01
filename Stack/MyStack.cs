using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Implementacion_Stack
{
    public class Nodo<T>
    {
        public T Dato;
        public Nodo<T> Siguiente;

        public Nodo(T Dato)
        {
            this.Dato = Dato;
        }
    }

    public class MyStack<T>
    {
        Nodo<T> Cima = null;
        int Count { get; set; }

        public MyStack()
        {
            Count = 0;
        }

        public void Push(T Value)
        {
            Nodo<T> Nuevo_Nodo = new Nodo<T>(Value);

            Nuevo_Nodo.Siguiente = Cima;

            Cima = Nuevo_Nodo;

            ++Count;
        }

        public T Pop()
        {
            T Value = Cima.Dato;

            Cima = Cima.Siguiente;

            --Count;

            return Value;
        }

        public T Peek()
        {
            return Cima.Dato;
        }

        public T[] GetArray()
        {
            T[] Array = new T[Count];

            Nodo<T> Aux = Cima;

            int i = 0;
            while (Aux != null)//Mientras no haya llegado al final
            {
                Array[i] = Aux.Dato;
                Aux = Aux.Siguiente;//Avanzo al siguiente nodo

                ++i;
            }


            return Array;
        }
    }
}
