﻿using System;
using System.Collections.Generic;
using Ninject;
using Text_Dominion.Demo;
using Text_Dominion.Interface;
using Text_Dominion.Ninject;

namespace Text_Dominion
{
    class Program
    {
        static void Main(string[] args)
        {
            //var kernel = new StandardKernel();
            //kernel.Load(new ApplicationNinjectBase());

            //var table = kernel.Get<ITable>();

            //new Demo.Demo1().Demo();
            DemoCarDecorator.Run();
        }
    }
}
