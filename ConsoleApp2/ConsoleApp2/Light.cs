using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Light
    {
        public bool IsTurnedOn { get; private set; }
        public int Brightness { get; private set; }
        public string Color { get; private set; }

        public void SwitchLight()
        {
            IsTurnedOn = !IsTurnedOn;
        }

        public void ChangeBrightness(int brightness)
        {
            Brightness = brightness;
        }

        public void ChangeColor(string color)
        {
            Color = color;
        }

        public override string ToString()
        {
            return $"Свет: Включён={IsTurnedOn}, Яркость={Brightness}, Цвет={Color}";
        }
    }
}
