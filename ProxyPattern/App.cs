﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class App
    {
        public void DoServiceOperation(IService service)
        {
            // SOME CODE

            service.DoOperation();

            // SOME CODE
        }
    }
}
