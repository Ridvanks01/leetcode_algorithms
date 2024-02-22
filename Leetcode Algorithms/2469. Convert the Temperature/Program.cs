using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2469.Convert_the_Temperature
{
    internal class Program
    {
        public double[] ConvertTemperature(double celsius)
        {
            double Kelvin = celsius + 273.15;
            double Fahrenheit = celsius * 1.80 + 32.00;

            double[] arr = new double[2];
            arr[0] = Kelvin;
            arr[1] = Fahrenheit;

            return arr;
        }
    }
}
