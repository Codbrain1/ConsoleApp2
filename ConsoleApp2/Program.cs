using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    internal class Program
    {

        struct SCAN
        {
            public double x;
            public double y;
            public int n;
            public double b;
            public int c;
            public int i;
            public double[] a;
        }


        static SCAN scan()
        {
            SCAN s;
            Console.WriteLine("введите x\n");
            s.x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите y\n");
             s.y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите n");
           s.n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите x");
            s.b = 0;
            s.c = 0;
            s.i = 0;
            s.a=new double[0];
          return s;

        }
        static SCAN recfunc(SCAN s)
        {
            s.a = new double[s.c];
            if (s.x * s.y > 1 && s.x * s.y < 10)
                s.a[s.i] = Math.Exp(s.x * s.x);
            else if (s.x * s.y > 12 && s.x * s.y < 40)
            {
                s.a[s.i] = Math.Sqrt(Math.Abs(s.x * s.x + 4 * s.y));
            }
            else 
                s.a[s.i] = Math.Pow(s.x, 2);

            if (s.x <= s.b)
                return s;
            else
            {
                s.i++;
                s.x = s.x + s.n;
               return recfunc(s);
            }

        }
       static SCAN process(SCAN s)
        {
            s.c = (10 / s.n) + 1;
            s.b = s.x + 10;
            double[] a= new double[s.c];
            s=recfunc(s);
            return s;
        }
        static void print(SCAN s)
        {
            for(int i=0; i<s.c; i++)
                Console.WriteLine(s.a[i]);
        }
        static void Main(string[] args)
        {
            int c, i = 0;
            double b;
          
            SCAN s;
            s=scan();
            process(s);
        }
    }
}
