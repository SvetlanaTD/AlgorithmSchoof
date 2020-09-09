using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SchoofAlgorithm
{
    public class BigModuloIntegerFactory
    {
        private BigInteger modulo;

        public BigModuloIntegerFactory(BigInteger modulo)
        {
            this.modulo = modulo;
        }

        public BigModuloInteger Create(BigInteger value)
        {
            return new BigModuloInteger(value, modulo);
        }

        public class BigModuloInteger
        {
            private BigInteger value;
            private BigInteger modulo;

            public BigModuloInteger(BigInteger value, BigInteger modulo)
            {
                this.value = value % modulo;
            }
        }
    }

}
