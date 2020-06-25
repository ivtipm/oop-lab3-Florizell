using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сhat_bot_lab3
{
    class WeatherResponse
    {
        public TempInfo Main { get; set; }

        public string Name { get; set; }

        public WindInfo Wind { get; set; }
    }
}
