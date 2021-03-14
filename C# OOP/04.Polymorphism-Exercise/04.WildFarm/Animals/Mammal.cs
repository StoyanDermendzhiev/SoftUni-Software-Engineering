﻿using System.Collections.Generic;

namespace _04.WildFarm.Animals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(
            string name, 
            double weight, 
            HashSet<string> allowedFoods, 
            double weightModifier,
            string livingRegion) 
            : base(name, weight, allowedFoods, weightModifier)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
