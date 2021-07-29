using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common

{
    // class representing complex numbers
    public class Complex
    {
        public double Real;
        public double Imaginary; 

        public Complex()
        {

        }
        public Complex(double r)
        {
            Real = r;
            Imaginary = 0;
        }

        public Complex(double r, double i)
        {
            Real = r;
            Imaginary = i;
        }
        // Convert valid strings to Real and Imaginery values
        public void Parse(string value)
        {
            var temp = value.Trim();
            if (temp.EndsWith("i") || temp.EndsWith("I"))
            {
                temp = temp.TrimEnd('i', 'I');
                var tokens = temp.Split(new[] { '+', '-' }, 2);
                Real = double.Parse(tokens[0]);
                Imaginary = double.Parse(tokens[1]);
            }
            else
            {
                Real = double.Parse(temp);
            }
        }


        //Convert valid strings to Real and Imaginery values
        public static Complex FromString(string value)
        {
            var temp = new Complex();
            temp.Parse(value);
            return temp;
        }

        //The property, returns the modulus of the complex number
        public double Modulus => Math.Sqrt(Real * Real + Imaginary * Imaginary);

        // Override the operator +
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        // Override the operator -

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        //Override object's ToString() method
        public override string ToString()
        {
            if (Imaginary == 0)
            {
                return Real.ToString();
            }

            return $"{Real} {(Imaginary > 0 ? '+' : '-')} {Math.Abs(Imaginary)}i";
        }
    }
}
