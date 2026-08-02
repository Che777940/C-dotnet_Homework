using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Homework.SmartHouse
{
    public class HubEvent
    {
        public enum SmartHouseType { Motion, FireAlarm, DoorOpened, LowBattery, TemperatureHigh };
        public DateTime date;
        public enum PriorityType {onePri = 1, twoPri = 2, threePri = 3, fourPri = 4, fivePri = 5 };
        public PriorityType priType;
        public SmartHouseType smartType;


        public override string ToString()
        {
            return $"Событие: {smartType}, время: {date}, важность: {priType} из 5";
        }
    }
}
