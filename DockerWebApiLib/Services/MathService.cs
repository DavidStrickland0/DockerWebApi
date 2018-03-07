using DockerWebApiLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DockerWebApiLib.Services
{
    public class MathService
    {
        public static decimal Add(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

    }
}
