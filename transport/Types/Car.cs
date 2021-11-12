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

        private readonly float _engineVolume;

        private readonly byte _numberDoors;

        private readonly string? _type;

        public Car(int type, float engineVolume, byte numberDoors)
        {
            _type = _typeCar[type];
            _engineVolume = engineVolume;
            _numberDoors = numberDoors;
        }
    }
}