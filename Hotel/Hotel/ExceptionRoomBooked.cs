using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
   
    public class ExceptionRoomBooked : Exception
    {
        public ExceptionRoomBooked()
        {
        }

        public ExceptionRoomBooked(string message)
            : base(message)
        {
        }

        public ExceptionRoomBooked(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
