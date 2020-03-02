using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    interface IConvertisseur
    {
        TypeCapteur typeCapteur { get; set; }
        double Convert(Unite U1, double val, Unite U2);
    }
}
