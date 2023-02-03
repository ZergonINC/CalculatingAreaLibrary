using CalculatingAreaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaLibrary.Shapes
{
    /// <summary>
    /// Класс фигуры прямоугольник. Конструктор принимает 2 положительных числа - стороны прямоугольника в double.
    /// </summary>
    public class Rectangle : IShape
    {
        private double _lengh;
        public double Lengh { get => _lengh; set => _lengh = value; }

        private double _width;
        public double Width { get => _width; set => _width = value; }

        private double? area;

        public Rectangle(double lengh, double width)
        {
            if (!double.IsNormal(lengh) || lengh <= 0)
                throw new ArgumentOutOfRangeException(nameof(lengh), "Число должно быть положительным!");
            if (!double.IsNormal(width) || width <= 0)
                throw new ArgumentOutOfRangeException(nameof(width), "Число должно быть положительным!");

            Lengh = lengh;
            Width = width;
        }

        /// <summary>
        /// Метод вычисляет площадь прямоугольника.
        /// </summary>
        /// <returns>Возращает double округленный до 3 чисел после запятой</returns>
        public double CalculateArea()
        {
            area ??= Math.Round(Lengh * Width, 3);

            return area.Value;
        }
    }
}
