using System;
using System.Collections.Generic;


namespace Func_Delegate
{
    class Program
    {
        public delegate  T Func<T, T1, T2>(T a, T1 b);

        public T Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return (x + y);
        }
        public T Mult<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return (x * y);
        }


        public T Method<T>(Func<T, T , T>func)
        {
            dynamic a = 2;
            dynamic b = 2;
            T result=  func.Invoke(a,b);
            return  result;
        }
     

        static void Main(string[] args)
        {
            
            Program p =new Program();
            Console.WriteLine("enter number 1");
            var n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number 2");
            var n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(p.Method<int>((a,b)=>p.Add(n1,n2)));
            Console.WriteLine( p.Method<int>((a,b)=> p.Mult(n1,n2)));
            Console.ReadLine();
        }
    }
}
