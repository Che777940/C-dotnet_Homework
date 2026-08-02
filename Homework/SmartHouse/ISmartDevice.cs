using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.SmartHouse
{
     public interface ISmartDevice
    {
        public string Name { get; }
        public void ReactToEvent(HubEvent eventData);
    }
}
