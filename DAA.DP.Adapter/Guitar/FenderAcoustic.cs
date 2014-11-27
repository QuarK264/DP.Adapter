using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.Adapter.Guitar
{
    class FenderAcoustic : IGuitar
    {
        public string Name { get; set; }

        public void Solo()
        {
            Console.WriteLine("На этой гитаре можно играть солол на всех ладах, то есть до 22.");
        }

        public void Courds()
        {
            Console.WriteLine("На этой гитаре аккорды звучат полнее (лучше качество материала) и легче ставить баре.");
        }
    }
}
