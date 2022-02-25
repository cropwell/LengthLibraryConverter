namespace LengthLibraryConverter
{
    public struct Foot : IMeasurement
    {
        public double Ft;

        public Foot(double ft)
        {
            this.Ft = ft;
        }

        public static implicit operator Foot(double foot)
        {
            return new Foot(foot);
        }

        public static implicit operator double(Foot foot)
        {
            return foot.Ft;
        }

        public static implicit operator Foot(Meter meter)
        {
            double conversionResult = meter / 0.3048;

            Foot temp = new Foot(conversionResult);
            return temp;
        }

        public override string ToString()
        {
            return Ft + " Feet";
        }
    }
}
