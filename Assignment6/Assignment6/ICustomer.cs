using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public interface ICustomer
    {
        string Name { get; }
        string Address { get; }
        int RoomNumber { get; }
        string ArrivalDate { get; }
        int NumberOfNights { get; }

    }
}
