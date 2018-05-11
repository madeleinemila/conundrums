using System;

namespace SolJose
{
    class Program
    {
        static int CalculateSteps(string s,int num)
        {
            int counting = 0, res=0;
            char[] aux = s.ToCharArray();
            bool[] DiscountOne = new bool [1005];
        
            for (int i = 0;i<aux.Length;i++)
            {
                if (aux[i]=='-'){
                    if (counting%2==0)
                    {
                        res++;
                        counting++;
                        if (i+num<=aux.Length)   DiscountOne[i+num-1] = true;
                    }
                }
                else{
                    if (counting%2!=0)
                    {
                        res++;
                        counting++;
                        if (i+num<=aux.Length)   DiscountOne[i+num-1] = true;
                    }
                }
                if (DiscountOne[i]==true) counting--;
            }

            if (counting==0) return res;
            else return -1;
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
