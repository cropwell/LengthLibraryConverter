using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthLibraryConverter
{
    public class Factory
    {
        public IMeasurement GetMeasurement(string measurementName, double amount = 0)
        {
            switch (measurementName)
            {
                case "Meter":
                    return new Foot(amount);
                case "Foot":
                    return new Meter(amount);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
