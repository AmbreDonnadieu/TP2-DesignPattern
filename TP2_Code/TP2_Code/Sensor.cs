using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_Code
{
    public interface Sensor
    {

        string SensorID { get; set; }
        double SensorValue { get; set; }
        
    }
}
