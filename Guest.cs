namespace Towers_cSharp
{
    public class Guest
    {
        private string name;

        public Guest(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}