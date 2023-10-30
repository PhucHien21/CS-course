using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public interface IAdmin
    {
        string FilePathHotel { get; }
        string FilePathRoom { get; }
        string FilePathCustomer { get; }
        ArrayList ReadFromFileCustomer();
        ArrayList ReadFromFileRoom();
        string GetHotelInfo();
        string SearchRoom(int roomNumeberSearch);
        string SearchCustomer(string customerNameSearch);
    }
}
