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
            { 1, "\\Pictures\\Porsh.jpg" },
            { 2, "\\Pictures\\Roket.jpg" },
            { 3, "\\Pictures\\SkyReact.jpg" },
            { 4, "\\Pictures\\vint.jpg" },
            { 5, "\\Pictures\\TurboVent.jpg" },
        };

        private readonly float _maxFlight;

        private readonly string? _type;

        public Airplane(byte countWheels, int type, float maxFlight)
        {
            _countWheels = countWheels;
            _type = _typeAirplane[type];
            _maxFlight = maxFlight;

            _image = _imageAirplane[type];
        }

        public override string Info()
        {
            return $"Количество колёс: {_countWheels}\n" +
                   $"Максимальная высота полета: {_maxFlight}\n" +
                   $"Тип: {_type}";
        }
    }
}