using System;
using System.Collections.Generic;
using System.Text;
using static Homework.SmartHouse.HubEvent;

namespace Homework.SmartHouse
{
    public class SecuritySiren : ISmartDevice
    {
        public string Name { get; }
        public SecuritySiren(string name, SmartHomeHub hub)
        {
            Name = name;
            hub.OnEvent += (sender, e) => ReactToEvent(e);
        }

        public void ReactToEvent(HubEvent e)
        {
            if (e.priType >= PriorityType.fivePri)
                Console.WriteLine($"{Name}: СИРЕНА ВКЛЮЧЕНА!");
        }
    }
}
