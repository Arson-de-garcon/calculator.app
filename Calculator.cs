﻿using System;
using System.Collections.Generic;
using System.Text;

namespace calculator.app
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }rrr

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double exp)
        {
            return Math.Pow(a, exp);
        }
    }
}
