using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        static void Main()
        {
            Thread threadPing = new Thread(() => ExecutarMensagens("PING", 10, 180));
            Thread threadPong = new Thread(() => ExecutarMensagens("PONG", 10, 200));

            Console.WriteLine("Iniciando...");
            threadPing.Start();

            threadPong.Start();    
        }

        static void ExecutarMensagens(string texto, int vezes, int delay)
        {
            for (int i = 0; i < vezes; i++)
            {
                Console.WriteLine(texto);
                Thread.Sleep(delay);
            }
        }
    }
}