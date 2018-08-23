using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    public struct Struct
    {
        private double val;
        public double Value
        {
            get { return val; }
            set { val = value; }
        }
        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
    }
    public struct Rectangle
    {
        Struct length;
        Struct breadth;

        public Struct Length
        {
            get { return length; }
            set { length = value; }
        }
        public Struct Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }
        public void newRectangle()
        {
            Struct rct = new Struct();
            length = sqrLength();
            Console.Write("Breadth : ");
            breadth.Value = rct.Read();
        }
        public Struct sqrLength()
        {
            Struct rct = new Struct();
            Console.Write("Length : ");
            rct.Value = rct.Read();
            return rct;
        }
    }
    public class structExarcise10
    {
        public static void Main()
        {
            Rectangle rect = new Rectangle();
            rect.newRectangle();
            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the square: ");

            Console.WriteLine("Length: {0}", rect.Length.Value);
            Console.WriteLine("Breadth: {0}", rect.Breadth.Value);
            Console.WriteLine("Perimeter: {0}", (rect.Length.Value + rect.Breadth.Value) * 2);
            Console.WriteLine("Area: {0}", rect.Length.Value * rect.Breadth.Value);

        }
    }
}
