using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БиКУКЛЕ
{
    internal class Circle:Figure
    {
        protected int _radius;
        
        protected int _area;

        public override void GetArea()
        {
            Console.WriteLine($"Площадь равна - {Math.Pow(Math.PI * _radius,2)}");
        }

        public override void SetNumber()
        {
            string side1 = Console.ReadLine();
            int side2 = int.Parse(side1);
            _radius = side2;
        }
    }
}
