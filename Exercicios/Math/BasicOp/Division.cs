﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Math.BasicOp
{
    public class Division
    {
        public double Calculate(double a, double b)
        {
            if (b == 0) {
                Console.WriteLine("Não é possível fazer divisão por zero!");    
                return 0;
            }
            else
            {
                return a / b;
            }
        }
    }
}