using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SchoofAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //GF gf = new GF(11);
            //GF.Poly poly = new GF.Poly();
            BigInteger x = BigInteger.Parse("49865498719871984357498794435498797976");
            BigInteger y = BigInteger.Parse("879876167868768498498498354089840897618");

            Console.WriteLine(y / x);
        }
    }
}
