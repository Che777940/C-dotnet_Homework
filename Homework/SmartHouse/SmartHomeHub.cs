using System;
using System.Collections.Generic;
using System.Text;
using static Homework.SmartHouse.HubEvent;

namespace Homework.SmartHouse
{
    public class SmartHomeHub
    {
        public event EventHandler<HubEvent> OnEvent;
        protected void RaiseEvent(HubEvent hubEvent)
        {
            Console.WriteLine("Получен сигнал");
            OnEvent.Invoke(this, hubEvent);
        }

        public void TriggerMotion()
        {
            HubEvent evt = new HubEvent
            {
                smartType = SmartHouseType.Motion,
                priType = PriorityType.threePri,
                date = DateTime.Now 
            };
            Console.WriteLine($"Сгенерировано событие {evt}");
        }

        public void TriggerFireAlarm()
        {
            HubEvent evt = new HubEvent
            {
                smartType = SmartHouseType.FireAlarm,
                priType = PriorityType.fivePri,
                date = DateTime.Now
            };

            Console.WriteLine($"Сгенерировано событие {evt}");
            RaiseEvent(evt);
        }

        public void TriggerMonitoring()
        {
            HubEvent evt = new HubEvent
            {
                smartType = SmartHouseType.FireAlarm,
                priType = PriorityType.fivePri,
                date = DateTime.Now
            };

            Console.WriteLine($"Сгенерировано событие {evt}");
            RaiseEvent(evt);
        }

        public void TriggerDoor()
        {
            HubEvent evt = new HubEvent
            {
                smartType = SmartHouseType.DoorOpened,
                priType = PriorityType.fivePri,
                date = DateTime.Now
            };

            Console.WriteLine($"Сгенерировано событие {evt}");
            RaiseEvent(evt);
        }

        public void TriggerLowBattery()
        {
            HubEvent evt = new HubEvent
            {
                smartType = SmartHouseType.LowBattery,
                priType = PriorityType.threePri,
                date = DateTime.Now
            };

            Console.WriteLine($"Сгенерировано событие {evt}");
            RaiseEvent(evt);
        }

        public void TriggerTemperature()
        {
            HubEvent evt = new HubEvent
            {
                smartType = SmartHouseType.TemperatureHigh,
                priType = PriorityType.fourPri,
                date = DateTime.Now
            };

            Console.WriteLine($"Сгенерировано событие {evt}");
            RaiseEvent(evt);
        }
    }
}
