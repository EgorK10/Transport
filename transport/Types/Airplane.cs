using System.Collections.Generic;

namespace transport.Types
{
    public class Airplane : Vehicles
    {
        private readonly Dictionary<int, string> _typeAirplane = new()
        {
            { 1, "Поршневой" },
            { 2, "Ракетный" },
            { 3, "Воздушно-реактивный" },
            { 4, "Турбовинтовой" },
            { 5, "Турбовентиляторный" }
        };

        private readonly Dictionary<int, string> _imageAirplane = new()
        {
            { 1, "" },
            { 2, "" },
            { 3, "" },
        };

        private readonly float _maxFlight;

        private readonly string? _type;

        public Airplane(int type, float maxFlight)
        {
            _type = _typeAirplane[type];
            _maxFlight = maxFlight;

            _image = _imageAirplane[type];
        }
    }
}