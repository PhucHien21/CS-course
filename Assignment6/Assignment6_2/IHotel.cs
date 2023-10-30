using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public interface IHotel
    {
        string Name { get; }
        string ConstructionDate { get; }
        string Address { get; }
        int NumberOfStars { get; }

        string WriteToFileHotel(string filePath);
        string WriteToFileRoom(string filePath);
        string WriteToFileCustomer(string filePath);
    }
}
