using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SmartHome
    {
        private Light light;
        private TV tv;
        private AirConditioner airConditioner;
        private MusicStation musicStation;

        public SmartHome()
        {
            light = new Light();
            tv = new TV();
            airConditioner = new AirConditioner();
            musicStation = new MusicStation();
        }

        public void SetUpHome(string mode)
        {
            switch (mode.ToLower())
            {
                case "ночной":
                    light.SwitchLight();
                    tv.SwitchTV();
                    airConditioner.Switch();
                    airConditioner.SetTemperature(20);
                    musicStation.Switch();
                    musicStation.SetMusic("Lofi Hip Hop");
                    break;

                case "вечеринка":
                    light.SwitchLight();
                    light.ChangeBrightness(100);
                    tv.SwitchTV();
                    tv.TurnOnProgram("Музыка для вечеринки");
                    airConditioner.Switch();
                    airConditioner.SetTemperature(22);
                    musicStation.Switch();
                    musicStation.SetMusic("Танцевальная музыка");
                    break;

                case "доброе утро":
                    light.SwitchLight();
                    light.ChangeBrightness(80);
                    tv.SwitchTV();
                    tv.TurnOnProgram("Новости");
                    airConditioner.Switch();
                    airConditioner.SetTemperature(24);
                    musicStation.Switch();
                    musicStation.SetMusic("Утренние мелодии");
                    break;

                case "ухожу":
                    light.SwitchLight();
                    tv.SwitchTV();
                    airConditioner.Switch();
                    musicStation.Switch();
                    break;

                case "один дома":
                    light.SwitchLight();
                    light.ChangeBrightness(50);
                    tv.SwitchTV();
                    tv.TurnOnProgram("Фильмы");
                    airConditioner.Switch();
                    airConditioner.SetTemperature(23);
                    musicStation.Switch();
                    musicStation.SetMusic("Спокойная музыка");
                    break;

                default:
                    Console.WriteLine("Неизвестный режим. Пожалуйста, выберите другой режим.");
                    return;
            }

            Console.WriteLine(light.ToString());
            Console.WriteLine(tv.ToString());
            Console.WriteLine(airConditioner.ToString());
            Console.WriteLine(musicStation.ToString());
        }
    }
}
