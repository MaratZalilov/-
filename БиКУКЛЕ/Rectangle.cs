using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БиКУКЛЕ
{
    internal class Rectangle:Figure
    {
        protected int _firstSide;
        protected int _secondSide;
        protected int _area;

        public override void GetArea()
        {
            _area =_firstSide * _secondSide;
            Console.WriteLine($"Площадь прямоугольника {_area}");
        }

        public override void SetNumber()
        {
            string side1 = Console.ReadLine();
            int side2 = int.Parse(side1);
            _firstSide = side2;
            string side3 = Console.ReadLine();
            int side4 = int.Parse(side3);
            _secondSide = side4;
        }
    }
}
