﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            new Net45.EvaluationEngineTest().Run();
            new Portable.EvaluationEngineTest().Run();
        }
    }
}
