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
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        
        
    }
    
    
}