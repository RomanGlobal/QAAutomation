using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class Figure
    {
        public event EventHandler<string> PerimeterCalculated;

        public int Length { get; set; }

        private int Radius { get; set; }

        public Figure(int Length)
        {
            this.Radius = 1;
            this.Length = Length;
            Console.WriteLine("base figure created");
        }

        public virtual int Perimeter()
        {
            Console.WriteLine("empty base perimeter");
            if (PerimeterCalculated != null)
                PerimeterCalculated(this, "Base class generated perimer event");

            return 0;
        }

        public int Square()
        {
            throw new NotImplementedException();
        }

    }


    public class Square : Figure
    {
        public Square(int Length) : base(Length)
        {


            Console.WriteLine("square created");
        }

        public override int Perimeter()
        {
            var res = base.Perimeter();

            Console.WriteLine("square reimplemented perimeter");
            return 4 * Length;
        }
    }


    public class Triangle : Figure
    {
        public Triangle(int Length) : base(Length)
        {


            Console.WriteLine("triangle created");
        }

        public override int Perimeter()
        {
            var res = base.Perimeter();

            Console.WriteLine("triangle reimplemented perimeter");
            return 3 * Length;
        }
    }
}
