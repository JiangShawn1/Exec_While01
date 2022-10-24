using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_While01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1+ 2 + 3 + 4 + .... + N <105
            //請問 N 是多少 ?

            int sum = 1;
            int N = 1;
            
            while (sum+N+1 < 105)
            {
                N++;
                sum=N+sum;            

            }
            Console.WriteLine(N);            
        }
    }
}
