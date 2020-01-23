using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class ExceptionEmptyBox : Exception

    {
        public ExceptionEmptyBox()
        {
        }

        public ExceptionEmptyBox(string message) : base(message)
        {
        }

        public ExceptionEmptyBox(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionEmptyBox(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
