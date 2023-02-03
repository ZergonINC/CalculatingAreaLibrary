using CalculatingAreaLibrary.Interfaces;

namespace CalculatingAreaLibrary.Shapes
{
    /// <summary>
    /// Класс фигуры круг. Конструктор принимает положительное число - радиус круга в double.
    /// </summary>
    public class Circle : IShape
    {
        private double _radius;
        public double Radius { get => _radius; set => _radius = value; }

        private double? area;

        public Circle(double radius)
        {
            if (!double.IsNormal(radius) || radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "Число должно быть положительным!");

            Radius = radius;
        }

        /// <summary>
        /// Метод вычисляет площадь круга.
        /// </summary>
        /// <returns>Возращает double округленный до 3 чисел после запятой</returns>
        public double CalculateArea()
        {
            area ??= Math.Round(Math.PI * Math.Pow(Radius, 2), 3);

            return area.Value;
        }
    }
}