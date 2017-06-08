using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace ConsoleApplication11
{
    class Program
    {

        public delegate int DelegateSample();
        public delegate void DelegateSample2();


        static void Main(string[] args)
        {
            var f1 = new Square(3);
            var f2 = new Triangle(17);

            f1.PerimeterCalculated += F1_PerimeterCalculated;

            var res = f1.Perimeter();

            f1.PerimeterCalculated -= F1_PerimeterCalculated;

            res = f1.Perimeter();



            DelegateSample del;
            del = f1.Perimeter;



            List<Figure> figures = new List<Figure> { f1, f2 };

            foreach (var f in figures)
                Console.WriteLine(f.Perimeter());
            Console.ReadKey();

        }

        private static void F1_PerimeterCalculated(object sender, string e)
        {
            Console.WriteLine("We got the notification!");
        }

        static void SampleDel2()
        {
            Console.WriteLine("Something to output");
        }
    }
}
