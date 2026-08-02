using System;
using System.Collections.Generic;
using System.Text;
using static Homework.SmartHouse.HubEvent;

namespace Homework.SmartHouse
{
    public class SmartLamp : ISmartDevice
    {
        public string Name { get; }
        public SmartLamp(string name, SmartHomeHub hub) 
        {
            Name=name;
            hub.OnEvent += (sender, e) => ReactToEvent(e);
            Console.WriteLine($"{Name} подключена.");
        }
        public void ReactToEvent(HubEvent e)
        {
            if (e.smartType == SmartHouseType.Motion)
            {
                Console.WriteLine($"{Name}: Свет ВКЛЮЧЁН");
            }
            else if (e.smartType == SmartHouseType.FireAlarm)
            {
                Console.WriteLine($"{Name}: Свет ВЫКЛЮЧЕН (пожар!)");
            }
        }
    }
}
