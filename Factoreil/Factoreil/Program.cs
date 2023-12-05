using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoreil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            long fact = 1;
            Console.WriteLine("yek adad baraye mohsebe factoril vared konid");
            n  =int.Parse(Console.ReadLine());
            for (i = n; i >= 1; i--)
            {
                fact *= i;    ///    fact=fast*i;   120
            }
            Console.WriteLine("factoril = " + fact);
            Console.ReadKey();
        }
    }
}
