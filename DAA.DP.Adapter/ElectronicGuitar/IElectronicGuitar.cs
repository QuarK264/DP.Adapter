using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.Adapter.ElectronicGuitar
{
    interface IElectronicGuitar
    {
        string Brand { get; }
        string Model { get; }
        string Features { get; }
        void Solo();
        void Chords();
    }
}
