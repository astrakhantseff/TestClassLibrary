using System.Security.Cryptography;

namespace TestClassLibrary
{
    public class Library : ITriangle
    {
        private double circle(double radius) => Math.PI * Math.Pow(radius, 2);

        private double triangle(params double[] args)
        {
            if (args.Length != 3) throw new ArgumentException();

            double a = args[0];
            double b = args[1];
            double c = args[2];

            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException();
            }

            (double catet1, double catet2, bool rightTriangle) = ITriangle.IsRightTriangle(a, b, c);

            if (rightTriangle)
            {
                return catet1 * catet2 / 2;
            }
            else
            {
                //формула герона {sqrt  {p*(p-a)(p-b)(p-c)}}
                //p — полупериметр
                double p = (a + b + c) / 2;
                return Math.Pow(p * (p - a) * (p - b) * (p - c), 2);
            }
        }

        private double octahedron(params double[] args)
        {
            if (args.Length != 8) throw new ArgumentException();
            bool isRight = args.Select(arg => arg != args[0] && arg > 0).Count() != 1;

            if (!isRight)
                throw new NotImplementedException();

            // 2a^{2}(1+{\sqrt {2}})}
            return 2 * Math.Pow(args[0], 2) * (1 + Math.Sqrt(2));
        }

        public double Square(double radius, params double[] args)
        {
            if (radius > 0)
                return circle(radius);

            if (args.Length == 0)
                throw new ArgumentException();

            return args.Length switch
            {
                3 => triangle(args),
                8 => octahedron(args),
                _ => throw new NotImplementedException()
            };
        }
    }
}