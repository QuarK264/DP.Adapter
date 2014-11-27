using DAA.DP.Adapter.ElectronicGuitar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.Adapter.Adapters
{
    class GuitarAdapter : IGuitar
    {
        private IElectronicGuitar electronicGuitar;

        public GuitarAdapter(IElectronicGuitar ElectronicGuitar)
        {
            electronicGuitar = ElectronicGuitar;
        }

        public string Name
        {
            get
            {
                return electronicGuitar.Model;
            }
            set
            {
                
            }
        }

        public void Solo()
        {
            Console.WriteLine("Марка: {0}", electronicGuitar.Brand);
            Console.WriteLine(electronicGuitar.Features);
            electronicGuitar.Solo();
        }

        public void Courds()
        {
            electronicGuitar.Chords();
        }
    }
}
