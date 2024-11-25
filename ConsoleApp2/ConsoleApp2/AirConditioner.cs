using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class AirConditioner
    {
        public bool IsTurnedOn { get; private set; }
        public int Temperature { get; private set; }

        public void Switch()
        {
            IsTurnedOn = !IsTurnedOn;
        }

        public void SetTemperature(int temperature)
        {
            Temperature = temperature;
        }

        public override string ToString()
        {
            return $"Контроллер Воздуха: Включён={IsTurnedOn}, Температура={Temperature}";
        }
    }
}
