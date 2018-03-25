using System;

namespace solution_Jose
{
    class Program
    {
        static int cont = 1;
        static int a => cont++; 
        static void Main(string[] args)
        {
            Console.WriteLine(a==1 && a==2&& a==3);
        }
    }
}
 