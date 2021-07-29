using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common
{
    //class that does the calculation
    public class Calculator

    {
            public double Cong(double x, double y)
            {
                return x + y;
            }
            public double Tru(double x, double y)
            {
                return x - y;
            }
            public double Nhan(double x, double y)
            {
                return x * y;
            }
            public double Chia(double x, double y)
            {
                return x / y;
            }
    }
}
