using CalculatingAreaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaLibrary.Shapes
{
    /// <summary>
    /// Класс фигуры треугольник. Конструктор принимает 3 положительных числа - стороны треугольника в double.
    /// </summary>
    public class Triangle : IShape
    {
        private double _firstSide;
        public double FirstSide { get => _firstSide; set => _firstSide = value; }

        private double _secondSide;
        public double SecondSide { get => _secondSide; set => _secondSide = value; }

        private double _thirdSide;
        public double ThirdSide { get => _thirdSide; set => _thirdSide = value; }

        private bool? _isExists;
        public bool IsExists
        {
            get
            {
                if (_isExists is null)
                {
                    _isExists = double.IsNormal(CalculateArea());
                }
                return _isExists.Value;
            }
        }

        private bool? _isRectangular;
        public bool IsRectangular
        {
            get
            {
                if (!IsExists)
                    return false;

                if (_isRectangular is null)
                {
                    double a = FirstSide, b = SecondSide, c = ThirdSide;
                    if (c < b)
                    {
                        (c, b) = (b, c);
                    }
                    if (c < a)
                    {
                        (c, a) = (a, c);
                    }
                    _isRectangular = c * c == b * b + a * a;
                }
                return _isRectangular.Value;
            }
        }

        private double? area;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (!double.IsNormal(firstSide) || firstSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(firstSide), "Число должно быть положительным!");
            if (!double.IsNormal(secondSide) || secondSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(secondSide), "Число должно быть положительным!");
            if (!double.IsNormal(thirdSide) || thirdSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(thirdSide), "Число должно быть положительным!");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        /// <summary>
        /// Метод вычисляет площадь треугольника.
        /// </summary>
        /// <returns>Возращает double округленный до 3 чисел после запятой</returns>
        public double CalculateArea()
        {
            if (area is null)
            {
                double halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

                area = Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide)), 3);
            }

            return area.Value;
        }
    }
}
