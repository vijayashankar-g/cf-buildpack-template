﻿using System.Linq;

namespace Lifecycle.Supply
{
    class Program
    {
        static void Main(string[] args)
        {
            var argsWithCommand = new[] {"release"}.Union(args).ToArray();
            new MyBuildpack.MyBuildpack().Run(argsWithCommand);
        }
    }
}