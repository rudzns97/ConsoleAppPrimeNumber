using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrimeNumber
{
    class Prime
    {
        public static void PrimeNum(int x, int y)
        {
            int num=0;
            int count=0;
            Console.Write("소수 : ");
            for (int i=x; i<=y; i++) //2부터 자기자신 까지
            {
                for(int k = 1; k <= i; k++)
                {
                    if (i % k == 0)
                    {
                        num++;
                    }
                }
                if (num == 2)
                {
                    
                    Console.Write(+i + " ");
                    count++;
                }
                num = 0;            
            }
            Console.WriteLine();
            Console.WriteLine("소수의 개수 : " + count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.Write("시작숫자 : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("끝숫자 : ");
            y = int.Parse(Console.ReadLine());

                if (y < 0)
                {
                    Console.WriteLine("양수를 입력해주세요"); return;
                }
                else if (y == 1)
                {
                    Console.WriteLine("소수가 없습니다."); return;
                }
                else 
                {
                Prime.PrimeNum(x, y);
                }
            
        }
    }
}
