using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MusicStation
    {
        public bool IsTurnedOn { get; private set; }
        public string Music { get; private set; }

        public void Switch()
        {
            IsTurnedOn = !IsTurnedOn;
        }

        public void SetMusic(string music)
        {
            Music = music;
        }

        public override string ToString()
        {
            return $"Музыкальная Станция: Включён={IsTurnedOn}, Музыка={Music}";
        }
    }
}
