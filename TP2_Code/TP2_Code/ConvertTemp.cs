using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    class ConvertTemp : IConvertisseur
    {
        public TypeCapteur typeCapteur { get; set; }

        public double Convert(Unite U1, double val, Unite U2)
        {
            if(U1 == Unite.celsius)
            {
                if (U2 == Unite.fahrenheit) { val += 32; }
                if (U2 == Unite.kelvin) {val+=273.15; }
            }
            if (U1 == Unite.fahrenheit)
            {
                if (U2 == Unite.celsius) { val -= 32; }
                if (U2 == Unite.kelvin) { val -= 459.67; }
            }
            if(U1== Unite.kelvin)
            {
                if (U2 == Unite.fahrenheit) { val += 459.67; }
                if (U2 == Unite.celsius) {val-=273.15; }
            }
            return val;
        }
    }
}
