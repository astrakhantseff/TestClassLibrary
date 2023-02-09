using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
using System.Diagnostics;
using TestClassLibrary;
using Xunit.Sdk;

namespace TestProject
{
    public class Test
    {
        [Fact]
        public void Right_Octo_Square()
        {
            Library library = new();
            double square = library.Square(0, 9, 9, 9, 9, 9, 9, 9, 9);
            double expected = 2 * Math.Pow(9, 2) * (1 + Math.Sqrt(2));
            Assert.Equal(expected, square);
        }

        [Fact]
        public void Right_Triangle_Square()
        {
            Library library = new();
            double square = library.Square(0, 10, 10, Math.Sqrt(200d));
            double expected = 10 * 10 / 2d;
            Assert.Equal(expected, square);
        }

        [Fact]
        public void Triangle_Square()
        {
            Library library = new();
            double square = library.Square(0, 9, 9, 9);
            double p = (9 + 9 + 9) / 2d;
            double expected = Math.Pow(p * (p - 9) * (p - 9) * (p - 9), 2);
            Assert.Equal(expected, square);
        }

        [Fact]
        public void Circle_Square()
        {
            Library library = new();
            double square = library.Square(10, 9);
            double expected = Math.PI * Math.Pow(10, 2);
            Assert.Equal(expected, square);
        }
    }
}