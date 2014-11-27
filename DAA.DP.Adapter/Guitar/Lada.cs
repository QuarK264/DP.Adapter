using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.Adapter.Guitar
{
    class Lada : IGuitar
    {
        public string Name { get; set; }

        public void Solo()
        {
            Console.WriteLine("На этой гитаре можно играть соло, используя ноты до 15 лада.");
        }

        public void Courds()
        {
            Console.WriteLine("На этой гитаре игра аккордов возможна, но ничем не примечательна.");
        }
    }
}
