﻿using System;

namespace pelda_tervminta_facade
{
    public class System1
    {
        public string DoSomething()
        {
            return "DoSomething() called";
        }
    }

    public class System2
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    public class Facade
    {
        private System1 _system1;
        private System2 _system2;

        public Facade()
        {
            _system1 = new System1();
            _system2 = new System2();
        }

        public void Run()
        {
            Console.WriteLine(_system1.DoSomething());
            Console.WriteLine("5 * 9 = {0}", _system2.Multiply(5, 9));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Facade f = new Facade();
            f.Run();
            Console.ReadKey();
        }
    }
}
