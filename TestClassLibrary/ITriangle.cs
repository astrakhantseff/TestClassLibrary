namespace TestClassLibrary
{
    internal interface ITriangle
    {
        public static Tuple<double, double, bool> IsRightTriangle(double a, double b, double c)
        {
            double hypotenuse = Math.Max(Math.Max(a, b), c);

            decimal a_sqr = (decimal)Math.Pow(a, 2);
            decimal b_sqr = (decimal)Math.Pow(b, 2);
            decimal c_sqr = (decimal)Math.Pow(c, 2);

            if (a == hypotenuse)
                return new Tuple<double, double, bool>(b, c, b_sqr + c_sqr == a_sqr);
            else if (b == hypotenuse)
                return new Tuple<double, double, bool>(a, c, a_sqr + c_sqr == b_sqr);
            else
                return new Tuple<double, double, bool>(a, b, a_sqr + b_sqr == c_sqr);
        }
    }
}