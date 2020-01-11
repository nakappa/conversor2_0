using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor_BIN_DEC_HEX_2
{
    class VerificadorExcepiton : Exception
    {
        public VerificadorExcepiton()
        {
        }

        public VerificadorExcepiton(string message) : base(message)
        {
        }
    }
}
