using System.Collections.Generic;

namespace transport.Types
{
    public class Car : Vehicles
    {
        private readonly Dictionary<int, string> _typeCar = new()
        {
            { 1, "Автобус" },
            { 2, "Грузовик" },
            { 3, "Внедорожник" },
            { 4, "Легковая" }
        };

        private readonly Dictionary<int, string> _imageCar = new()
        {
            { 1, "\\Pictures\\Bus.jpg" },
            { 2, "\\Pictures\\Height.jpg" },
            { 3, "\\Pictures\\Dirt.jpg" },
            { 4, "\\Pictures\\Car.jpg" },
        };

        private readonly float _engineVolume;

        private readonly byte _numberDoors;

        private readonly string? _type;

        public Car(byte countWheels, int type, float engineVolume, byte numberDoors)
        {
            _countWheels = countWheels;
            _type = _typeCar[type];
            _engineVolume = engineVolume;
            _numberDoors = numberDoors;

            _image = _imageCar[type];
        }

        public override string Info()
        {
            return $"Количество колёс: {_countWheels}\n" +
                   $"Объём двигателя: {_engineVolume}\n" +
                   $"Количество дверей: {_numberDoors}\n" +
                   $"Тип: {_type}";
        }
    }
}