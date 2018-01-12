using DDD.Domain.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Fishing
{
    public class FishingEventHandler : IEventHandler<FishingEventData>
    {
        public void HandleEvent(FishingEventData eventData)
        {
            eventData.FishingMan.FishCount++;
            Console.WriteLine($"{eventData.FishingMan.Name}：钓到一条[{eventData.FishType}]，已经钓到{eventData.FishingMan.FishCount}条鱼了！");

        }
    }
}
