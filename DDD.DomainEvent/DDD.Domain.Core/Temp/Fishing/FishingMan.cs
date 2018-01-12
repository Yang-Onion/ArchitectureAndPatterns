using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Fishing
{
    public class FishingMan
    {
        public string Name { get; set; }
        public int FishCount { get; set; }
        public FishingRod FishingRod { get; set; }

        public void Fishing()
        {
            FishingRod.ThrowHook(this);
        }

        public void Update(FishType fishType)
        {
            FishCount++;
            Console.WriteLine($"{Name}：钓到一条[{fishType}]，已经钓到{FishCount}条鱼了！");
        }
    }
}
