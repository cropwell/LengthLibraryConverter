namespace LengthLibraryConverter
{
    public struct Meter : IMeasurement
    {
        public double meter;

        public Meter(double m)
        {
            this.meter = m;
        }

        public static implicit operator Meter(double meter)
        {
            return new Meter(meter);
        }

        public static implicit operator double(Meter meter)
        {
            return meter.meter;
        }

        public static implicit operator Meter(Foot ft)
        {
            double conversionResult = 3.2808399 * ft;

            Meter temp = new Meter(conversionResult);
            return temp;
        }

        public override string ToString()
        {
            return meter + " Meter";
        }

    }
}
