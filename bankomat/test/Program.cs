using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int miqdar = 0;
            int[] count = new int[6];
            count[0] = 100;
            count[1] = 50;
            count[2] = 20;
            count[3] = 10;
            count[4] = 5;
            count[5] = 1;
            Console.Write("Bankomatdan cixaracaginiz miqdari daxil edin:");
            int money = int.Parse(Console.ReadLine());
            for (int i = 0; i < count.Length; i++)
            {
                miqdar = money / count[i];
                Console.Write(miqdar+" eded " + count[i]+", ");
                money = money % count[i];

            }
            Console.ReadLine();
        }
    }
}
