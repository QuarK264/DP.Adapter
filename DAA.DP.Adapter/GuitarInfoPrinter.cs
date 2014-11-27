using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.Adapter
{
    class GuitarInfoPrinter
    {
        internal static void PrintGuitarInfo(IGuitar Guitar)
        {
            Console.WriteLine("Информация о гитаре:");
            Console.WriteLine("Название гитары: {0}", Guitar.Name);
            Console.WriteLine("Особенности звучания соло:");
            Guitar.Solo();
            Console.WriteLine("Особенности звучания аккордов:");
            Guitar.Courds();

            Console.WriteLine();
        }
    }
}
