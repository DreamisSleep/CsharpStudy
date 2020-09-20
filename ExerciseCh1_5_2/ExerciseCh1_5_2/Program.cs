using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCh1_5_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 1, j = 0, k;
            try
            {
                Console.WriteLine("Exception checking....");
                k = i / j;
                Console.WriteLine("After Exception happening...");
            }catch(Exception e)
            {
                Console.WriteLine("Caught Exception");
            } finally {
                Console.WriteLine("In the finally state");
            }
        }
    }
}
