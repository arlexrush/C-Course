﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Estrategia
{
    class Csuma:IOperacion
    {
        public double operacion(double a, double b)
        {
            return a + b;
        }
    }
}
