﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Service : ICalculatable
    {
        public double GetAmount()
        {
            return -2000;
        }
    }
}
