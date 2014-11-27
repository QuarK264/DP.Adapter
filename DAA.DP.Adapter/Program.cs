namespace DAA.DP.Adapter
{
    using DAA.DP.Adapter.Adapters;
    using DAA.DP.Adapter.ElectronicGuitar;
    using DAA.DP.Adapter.Guitar;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            IGuitar Lada = new Lada();
            Lada.Name = "Обычная акустическая гитара Лада";
            GuitarInfoPrinter.PrintGuitarInfo(Lada);

            IGuitar FenderAcoustic = new FenderAcoustic();
            FenderAcoustic.Name = "Акустическая гитара фирмы Fender";
            GuitarInfoPrinter.PrintGuitarInfo(FenderAcoustic);

            IElectronicGuitar LesPaul = new GibsonLesPaul();
            GuitarAdapter adapter = new GuitarAdapter(LesPaul);
            GuitarInfoPrinter.PrintGuitarInfo(adapter);

            Console.ReadLine();
        }
    }
}
