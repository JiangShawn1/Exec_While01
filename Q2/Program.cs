using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {//使用 while , 在畫面顯示所有可以整除 300 的整數
         //例如: 1, 2, 3, 4, 5, 6, 10, ...., 300
            
            int N = 0;

            while (N<=300)
            {
                N++;
                if (300 % N == 0)
                {
                    Console.WriteLine(N);                    
                }
                
                
            }
        }
    }
}
