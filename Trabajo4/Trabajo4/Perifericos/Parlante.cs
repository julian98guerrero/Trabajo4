﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo4.Perifericos
{
    internal class Parlante : IPerifericos
    {
        public void Conectar()
        {
            Console.WriteLine("Se conecto un parlante por usb");

        }
    }
}
