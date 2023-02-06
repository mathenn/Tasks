using System.Globalization;

namespace Task_table_3
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Width * Width + Height * Height);
        }
        
    }
}
