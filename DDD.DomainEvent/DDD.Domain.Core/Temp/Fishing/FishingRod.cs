using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Fishing
{
    public class FishingRod
    {
        public delegate void FishingHandler(FishType fishType);
        public event FishingHandler FishingEvent;

        public void ThrowHook(FishingMan fishingMan)
        {
            Console.WriteLine("begin fishing~~~~");
            if (new Random().Next() %2==0)
            {
                var fishType = (FishType)new Random().Next(0, 5);

                Console.WriteLine("ding~ ding ~ catch a fish~");
                var eventData = new FishingEventData() { FishType = fishType, FishingMan = fishingMan };
                               
            }
        }
    }
}
