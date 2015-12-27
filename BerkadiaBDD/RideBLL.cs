using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerkadiaBDD
{
    class RideBLL
    {
        public string validate(Ride ride)
        {
            Console.Write(ride.Name);
            if(string.IsNullOrEmpty(ride.Name))
            {
                return "Name can't be blank";
            }
            else
            return "Posting was successful.";
        }
    }
}
