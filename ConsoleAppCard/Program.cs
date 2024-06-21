using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 配列
            int[] card = new int[4];

            // 配列分繰り返す
            for (int i = 0; i < card.Length; i++)
            {
                Console.WriteLine("{0}番目のカードを入力してください。 >",i+1);
                string inputStr = Console.ReadLine();
                int.TryParse(inputStr, out card[i]);
            }
            Console.ReadLine();

        }
    }
}
