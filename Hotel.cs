using System.Collections.Generic;

namespace Towers_cSharp
{
    public class Hotel
    {
        private List<Bedroom> _bedrooms;
        private List<ConferenceRoom> _conferenceRooms;
        private Dictionary<string, DiningRoom> _diningRooms;

        public Hotel()
        {
            _bedrooms = new List<Bedroom>();
            _conferenceRooms = new List<ConferenceRoom>();
            _diningRooms = new Dictionary<string, DiningRoom>();
        }

        public void addBedroom(Bedroom bedroom)
        {
            _bedrooms.Add(bedroom);
        }

        

        public void addConferenceRoom(ConferenceRoom conferenceRoom)
        {
            _conferenceRooms.Add((conferenceRoom));
        }

        public void addDiningRoom(DiningRoom diningRoom)
        {
            _diningRooms.Add(diningRoom.Name, diningRoom);
        }

        public Bedroom findBedRoom(int roomNumber)
        {
            Bedroom foundRoom = null;
            {
                foreach(Bedroom bedroom in _bedrooms)
                {
                    if (bedroom.RoomNumber == roomNumber)
                    {
                        foundRoom = bedroom;
                    }
                }

                return foundRoom;
            }
        }

        // public Bedroom findRoom(int i)
        // {
        //     throw new System.NotImplementedException();
        // }
    }
    
    
}