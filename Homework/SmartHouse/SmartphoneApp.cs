using System;
using System.Collections.Generic;
using System.Text;
using static Homework.SmartHouse.HubEvent;

namespace Homework.SmartHouse
{
    public class SmartphoneApp : ISmartDevice
    {
        public string Name { get; }
        public SmartphoneApp(string name, SmartHomeHub hub)
        {
            Name = name;
            hub.OnEvent += (sender, e) => ReactToEvent(e);
        }

        public void ReactToEvent(HubEvent e)
        {
            if (e.priType > PriorityType.twoPri)
                Console.WriteLine($"{Name}: Уведомление: {e.smartType}");
        }
    }
}
