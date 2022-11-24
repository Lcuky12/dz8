using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кристалл
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 10;
            int gold;
            int totalCrystal;
            Console.Write(" Сколько криссталов вам нужно? ");
            totalCrystal = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Сколько у вас золота? ");
            gold = Convert.ToInt32(Console.ReadLine());          
            Console.WriteLine(" У вас золота осталось " + (gold - price * totalCrystal) + " У вас криссталов " + totalCrystal);
        }
    }
}
