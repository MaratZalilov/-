using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БиКУКЛЕ
{
    internal class Square:Figure
    {
        protected int _side;


        public override void SetNumber()
        {
            string side1 = Console.ReadLine();
            int side2 = int.Parse(side1);
            _side = side2;
        }
        public override void GetArea()
        {
            _side = _side * _side;
            Console.WriteLine($"Площадь квадрата {_side}");
        }
    }
}
