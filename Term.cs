using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SchoofAlgorithm
{
    public partial class GF
    {
        private BigInteger order;

        public GF(BigInteger order)
        {
            this.order = order;
        }

        public class Term
        {
            private BigInteger coeff;
            private BigInteger exponent;

            public Term(BigInteger coeff, BigInteger exponent)
            {
                this.coeff = coeff;
                this.exponent = exponent;
            }

            public BigInteger Coeff
            {
                get { return coeff; }
            }

            public BigInteger Exponent
            {
                get { return exponent; }
            }

            public override string ToString()
            {
                return String.Format("{0}*x^{1}", coeff, exponent);
            }
        }
    }
}
