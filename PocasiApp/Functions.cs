using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocasiApp
{
    public class Functions
    {
        public static double? KelvinToCelsiusRound(double? FirstTemp)
        {
            double? SecondTemp = Math.Round((double)(FirstTemp - 273.16));
            return SecondTemp;
        
        }

        
    }
}
