using System;
using System.Threading;

namespace Threads_I
{
    class Program
    {
        static void Main(string[] args)
           //el threath hace que que haya dos hilos haciendose al mismo tiempo
        {//aqui se crea un hilo y por convercion se utiliza solo la t con numeros
            Thread t1 = new Thread(metodoSaludo);
            //inicia la tarea
            t1.Start();
            //Hace que se sincronize, mientras ese no termina la otra no comienza
            t1.Join();
            //hace que hilo principar dure 0.5 segundos en mandar el mensaje

            Thread t2 = new Thread(metodoSaludo);
            t2.Start();
            t2.Join();

            Console.WriteLine("Hola alumnos desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola alumnos desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola alumnos desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola alumnos desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola alumnos desde thread 1");

            //metodoSaludo();
           
        }

        static void metodoSaludo()
        {
            Console.WriteLine("Hola alumnos desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola alumnos desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola alumnos desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola alumnos desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola alumnos desde thread 2");
        }
    }
}
