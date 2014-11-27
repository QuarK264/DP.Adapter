using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.Adapter.ElectronicGuitar
{
    class GibsonLesPaul : IElectronicGuitar
    {
        public string Brand
        {
            get { return "Gibson"; }
        }

        public string Model
        {
            get { return "Les Paul Standard"; }
        }

        public string Features
        {
            get { return "Для полноценного звучания гитаре необходимо подключение в комбоусилитель или предусилитель (голову)."; }
        }

        public void Solo()
        {
            Console.WriteLine("В соло возможно использовать в полной мере различные приёмы (из-за подключения), перегруженные звуки, на грифе 22 лада.");
        }

        public void Chords()
        {
            Console.WriteLine("В аккордах также могут быть различные приёмы, звук можеть быть перегружнен.");
        }
    }
}
