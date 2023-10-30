using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public interface IRoom
    {
        int RoomNumber { get; }
        string Area { get; }
        string Type { get; }
        double PricePerNight { get; }
        string Description { get; }

    }
}
