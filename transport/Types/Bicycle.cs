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
            { 1, "" },
            { 2, "" },
            { 3, "" },
        };

        private readonly byte _wheelRadius;

        private readonly string? _type;

        public Bicycle(int type, byte wheelRadius)
        {
            _type = _typeBicycle[type];
            _wheelRadius = wheelRadius;

            _image = _imageBicycle[type];
        }
    }
}