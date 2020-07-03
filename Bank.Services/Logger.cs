using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Services
{
    class Logger
    {
        public static void Log(string p)
        {
            throw new Exception("Simulated out of memory exception");
        }
    }
}
