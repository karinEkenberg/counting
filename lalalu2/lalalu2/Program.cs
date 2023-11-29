using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lalalu2
{
    class Program
    {
        static int RäknaBokstäver(string taEmot)
        {
           // int räknare = taEmot.Length;
            return taEmot.Length;
        }
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Var god skriv in ett värde (Lämna blankt för att avsluta).");
                string input = Console.ReadLine();  
                if (input == "")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Du skrev värdet: " + input);
                    Console.WriteLine("Det har antalet bokstäver: " + RäknaBokstäver(input));
                }
            }



        }
    }
}
