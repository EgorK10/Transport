namespace transport.Types
{
    public abstract class Vehicles
    {
        protected byte _countWheels;
        protected string? _image;

        public string? Image => _image;
        public abstract string Info();
    }
}