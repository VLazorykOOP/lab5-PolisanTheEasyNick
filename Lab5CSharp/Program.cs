using System;
using Microsoft.VisualBasic.FileIO;

namespace Lab5CSharp
{
    class Engine
    {
        protected string Model;

        public Engine()
        {
            Model = "Default engine";
        }

        public Engine(string m)
        {
            Model = m;
        }

        public Engine(int m)
        {
            Model = m.ToString();
        }

        ~Engine()
        {
            Console.WriteLine("Destructor Engine");
        }


        public void Show()
        {
            Console.WriteLine($"Model: {Model}");
        }

    }

    class InternalEngine : Engine
    {
        private readonly double _v;

        public InternalEngine()
        {
            _v = 5;
            Model = "Internal engine";
        }
        public InternalEngine(double v)
        {
            _v = v;
            Model = "React engine";
        }

        public InternalEngine(double v, string m) : base(m)
        {
            _v = v;
        }

        ~InternalEngine()
        {
            Console.WriteLine("Destructor Internal Engine");
        }
        public new void Show()
        {
            Console.WriteLine($"Model: {Model}\nV: {_v}");
        }
    }

    class DieselEngine : Engine
    {
        private readonly double _v;

        public DieselEngine()
        {
            _v = 2;
            Model = "Diesel engine";
        }
        public DieselEngine(double v)
        {
            _v = v;
            Model = "React engine";
        }

        public DieselEngine(double v, string m) : base(m)
        {
            _v = v;
        }

        ~DieselEngine()
        {
            Console.WriteLine("Destructor Diesel Engine");
        }
        public new void Show()
        {
            Console.WriteLine($"Model: {Model}\nV: {_v}");
        }
    }

    class ReactEngine : Engine
    {
        private readonly double _v;

        public ReactEngine()
        {
            _v = 6;
            Model = "React engine";
        }
        public ReactEngine(double v)
        {
            _v = v;
            Model = "React engine";
        }

        public ReactEngine(double v, string m) : base(m)
        {
            _v = v;
        }

        ~ReactEngine()
        {
            Console.WriteLine("Destructor React Engine");
        }
        public new void Show()
        {
            Console.WriteLine($"Model: {Model}\nV: {_v}");
        }
    }

    internal abstract class Function
    {
        abstract public double Calculate(double x);
    }

    class Line : Function
    {
        public double a, b;
        public Line()
        {
            a = 0;
            b = 0;
        }
        public Line(double a_, double b_)
        {
            a = a_;
            b = b_;
        }
        public override double Calculate(double x)
        {
            return a * x + b;
        }
    }

    class Quadratic : Function
    {
        public double a, b, c;
        public Quadratic()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public Quadratic(double a_, double b_, double c_)
        {
            a = a_;
            b = b_;
            c = c_;
        }
        public override double Calculate(double x)
        {
            return a * x * x + b * x + c;
        }
    }
    
    class Hyperbola : Function
    {
        public double k;
        public Hyperbola()
        {
            k = 0;
        }
        public Hyperbola(double k_)
        {
            k = k_;
        }
        public override double Calculate(double x)
        {
            return k/x;
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Show();
            InternalEngine internalEngine = new(5, "Internal");
            internalEngine.Show();
            ReactEngine reactEngine = new(2.2);
            reactEngine.Show();
            DieselEngine dieselEngine = new();
            dieselEngine.Show();
            
            //----
            Line line = new(3, 6);
            Console.WriteLine(line.Calculate(2).ToString());
            Quadratic quad = new(1, 2, 3);
            Console.WriteLine(quad.Calculate(2).ToString());
            Hyperbola hyp = new(4);
            Console.WriteLine(hyp.Calculate(2).ToString());
            Console.WriteLine("End of main");
        }
    }
}
