namespace DAA.DP.Adapter
{using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    interface IGuitar
    {
        string Name { get; set; }
        void Solo();
        void Courds();
    }
}
