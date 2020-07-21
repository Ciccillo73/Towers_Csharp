using System;
using System.Collections.Generic;

namespace Towers_cSharp
{
    public class Bedroom
    {
        private int _roomNumber;
        private int _capacity;
        private string _type;
        private double _nightlyRate;
        private List<Guest> _guests;


        public Bedroom(int roomNumber, int capacity, string type, double nightlyRate)
        {
            _roomNumber = roomNumber;
            _capacity = capacity;
            _type = type;
            _nightlyRate = nightlyRate;
            _guests = new List<Guest>();
            
        }

        public int RoomNumber
        {
            get => _roomNumber;
            set => _roomNumber = value;
        }

        public int Capacity
        {
            get => _capacity;
            set => _capacity = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }

        public double NightlyRate
        {
            get => _nightlyRate;
            set => _nightlyRate = value;
        }

        public int countGuestList()
        {
            return _guests.Count;
        }

        public void checkInGuests(Guest guest)
        {
            _guests.Add(guest);
        }

        public void checkOutGuests()
        {
            if (!this.IsVacant())
            {
                _guests.Clear();
            }
        }

        public bool IsVacant()
        {
            return countGuestList() == 0;
        }


        
    }
    
}