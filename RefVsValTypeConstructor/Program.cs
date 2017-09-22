using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVsValTypeConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass SClass = new SomeClass(5); // Calling  constructor "public SomeClass()" 
                                                 // and after initialize m_x=5
            SClass.Info();
            Console.WriteLine();
            AnotherClass AClass = new AnotherClass();
            AClass.Info();
            Console.WriteLine();
            Rectangle rectangle = new Rectangle();
            
            Console.ReadKey();
        }


    }
    public class SomeClass
    {
        public int m_x;
        public string m_s;
        public double m_d;
        public byte m_b;

        public SomeClass()
        {
            Console.WriteLine("SomeClass() constructor");
            m_x = 2;
            m_s = "Hello";
            m_d = 7.1231341343;
            m_b = 100;
        }

        public SomeClass(int x) : this()
        {
            Console.WriteLine("SomeClass(int x) constructor");
            m_x = x;
        }

        public SomeClass(string s) : this()
        {
            Console.WriteLine("SomeClass(string s) constructor");
            m_s = s;
        }

        public SomeClass(int x, string s) : this()
        {
            Console.WriteLine("SomeClass(int x, string s) constructor");
            m_x = x;
            m_s = s;
        }

        public virtual void Info()
        {
            Console.WriteLine("m_x = {0}, m_s = {1}, m_d = {2}, m_b = {3}", m_x, m_s, m_d, m_b);
        }
    }

    public class AnotherClass : SomeClass
    {
        public int ma_x;
        public string ma_s;

        public AnotherClass()
        {
            Console.WriteLine("AnotherClass() constructor");
            ma_x = 123;
            ma_s = "How are you";
        }

        public override void Info()
        {
            Console.WriteLine("m_x = {0}, m_s = {1}, m_d = {2}, m_b = {3}, ma_x = {4}, ma_s = {5}",
                m_x, m_s, m_d, m_b, ma_x, ma_s);
        }


    }

    public struct Point
    {
        public int mx_x, mx_y;

        public Point(int x, int y)
        {
            Console.WriteLine("Public Point(int x, int y) constructor");
            mx_x = x;
            mx_y = y;
        }
    }

    public class Rectangle
    {
        public Point m_left, m_right;

        public Rectangle()
        {
            m_left = new Point(1, 3);  // Calling struct constructor there
            m_right = new Point(4, 5); // and there

        }
    }
}

