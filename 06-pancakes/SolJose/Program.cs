using System;

namespace SolJose
{
    class Program
    {
        static int CalculateSteps(string s,int num)
        {
            int res = 0,index = 0, i;
            char[] aux = s.ToCharArray();

            while (true)
            {
                for (i = index;i<aux.Length;i++)
                    if (aux[i] == '-'){
                        index = i;
                        break;
                    }
                
                if (i >= aux.Length) break;
                if (index+num > aux.Length) return -1;
                res++;

                for (int j=index; j<index+num; j++)
                    aux[j] = aux[j]=='-'? '+':'-';
            }
            return res;
        }
        static void Main(string[] args)
        {
            int n  = Int32.Parse(Console.ReadLine());
            
            for (int i = 1; i<=n; i++)
            {
               string input = Console.ReadLine();
               string[] split = input.Split(' ');
               int res = CalculateSteps(split[0],Int32.Parse(split[1]));
               if (res == -1)  Console.WriteLine("Case #{0}: IMPOSSIBLE",i);
               else Console.WriteLine("Case #{0}: {1}",i,res);
            }
        }
    }
}
