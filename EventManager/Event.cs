using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    public class Event
    {
        string _name;
        string _date;
        string _location;

        public Event(string name, string date, string location)
        {
            _name = name;
            _date = date;
            _location = location;
        }
    }
}
