using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TV
    {
        public bool IsTurnedOn { get; private set; }
        public string Program { get; private set; }

        public void SwitchTV()
        {
            IsTurnedOn = !IsTurnedOn;
        }

        public void TurnOnProgram(string program)
        {
            Program = program;
        }

        public override string ToString()
        {
            return $"Телевизор: Включён={IsTurnedOn}, Действующая программа={Program}";
        }
    }
}
