using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo4.Hardwares
{
    internal abstract class Hardware
    {
        public void Conectar()
        {
            Console.WriteLine("Conectar a la placa");
        }
        public abstract void ConeccionElectronica();


    }
}
