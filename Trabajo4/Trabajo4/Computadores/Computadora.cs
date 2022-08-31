using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo4.Hardwares;
using Trabajo4.Perifericos;


namespace Trabajo4.Computadores
{
    internal class Computadora
    {
        private IPerifericos Perifericos;
        private Hardware RAM;
        private Hardware Procesador;
        private IPerifericos perifericos1;

        public Computadora(IPerifericos perifericos, IPerifericos perifericos1)
        {
            Perifericos = perifericos;
            this.RAM = new RAM();
            this.Procesador = new Procesador();
            this.perifericos1 = perifericos1;
        }
    }
}
