using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static6
{
    static class Calculator
    {
        //static public double A { get; set; }
        //static public double B { get; set; }

        //static Calculator()
        //{
        //    A = 0d; B = 0d;
        //}

        static public double Sum(double A, double B)
        {            
            return A + B;            
        }

        static public double Diff(double A, double B)
        {
            return A - B;
        }

        static public double Mult(double A, double B)
        {
            return A * B;
        }

        static public double Div(double A, double B)
        {
            return A / B;
        }

    }
}

