using System.Collections.Generic;

namespace transport.Types
{
    public class Bicycle : Vehicles
    {
        private readonly Dictionary<int, string> _typeBicycle = new()
        {
            { 1, "Горный" },
            { 2, "Городской" },
            { 3, "Детский" }
        };

        private readonly Dictionary<int, string> _imageBicycle = new()
        {
            { 1, "\\Pictures\\Rock.jpg" },
            { 2, "\\Pictures\\City.jpg" },
            { 3, "\\Pictures\\Childe.jpg" },
        };

        private readonly byte _wheelRadius;

        private readonly string? _type;

        public Bicycle(byte countWheels, int type, byte wheelRadius)
        {
            _countWheels = countWheels;
            _type = _typeBicycle[type];
            _wheelRadius = wheelRadius;

            _image = _imageBicycle[type];
        }

        public override string Info()
        {
            return $"Количество колёс: {_countWheels}\n" +
                   $"Радиус колес: {_wheelRadius}\n" +
                   $"Тип: {_type}";
        }
    }
}