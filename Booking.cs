namespace Towers_cSharp
{
    public class Booking
    {
        private int _numberOfNights;
        private Bedroom _bedroom;

        public Booking(int numberOfNights, Bedroom bedroom)
        {
            _numberOfNights = numberOfNights;
            _bedroom = bedroom;
        }

        public int NumberOfNights
        {
            get => _numberOfNights;
            set => _numberOfNights = value;
        }

        public Bedroom Bedroom
        {
            get => _bedroom;
            set => _bedroom = value;
        }
        
        
    }
    
}