using System.Collections.Generic;

namespace Towers_cSharp
{
    public class DiningRoom
    {
        private string _name;
        private List<Guest> _guests;

        public DiningRoom(string name)
        {
            _name = name;
            _guests = new List<Guest>();
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int guestListSize()
        {
            return _guests.Count;
        }

        public void checkInGuests(Guest guest)
        {
            _guests.Add(guest);
        }
    }
    
    
}