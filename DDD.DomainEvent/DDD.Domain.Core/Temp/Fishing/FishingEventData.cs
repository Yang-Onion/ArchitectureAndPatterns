using DDD.Domain.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Fishing
{
    public class FishingEventData:EventData
    {
        public FishingMan FishingMan { get; set; }
        public FishType FishType { get; set; }
    }
}
