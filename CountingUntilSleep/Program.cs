using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingUntilSleep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSheeps(new bool[] { true, false, true }));
        }
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(x => x);
        }
        public static int CountSheeps1(bool[] sheeps)
        {
            int c = 0;
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i])
                {
                    c++;
                }
            }
            return c;
        }
    }
}
