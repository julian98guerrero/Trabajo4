using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo4.Hardwares
{
    internal class RAM : Hardware
    {
        public override void ConeccionElectronica()
        {
            Console.WriteLine("conecta a 5v");
        }
    }
}
