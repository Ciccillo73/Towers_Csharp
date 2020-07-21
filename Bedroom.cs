using System.Collections.Generic;

namespace Towers_cSharp
{
    public class Bedroom
    {
        private int roomNumber;
        private int capacity;
        private string type;
        private double nightlyRate;
        private List<Guest> guests;


        public Bedroom(int roomNumber, int capacity, string type, double nightlyRate)
        {
            this.roomNumber = roomNumber;
            this.capacity = capacity;
            this.type = type;
            this.nightlyRate = nightlyRate;
        }
    }
    
}