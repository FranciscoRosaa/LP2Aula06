using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearAdapter
{
    public class BrownBear : IBear
    {
        private readonly Random random;

        public bool Hibernating { get; private set; }

        public void GoTowards(object objectToWalkTowards)
        {
            if (!Hibernating)
            {
                Console.WriteLine($"Brown Bear moved towards " + objectToWalkTowards);
                if (random.NextDouble() < 0.2)
                {
                    Hibernating = true;
                }
            }
        }
        

        public void LookAt(object objectToLookAt)
        {
            if (!Hibernating)
            {
                Console.WriteLine($"Brown Bear is looking at " + objectToLookAt);
            }
        }

        public void Roar()
        {
            if (Hibernating && random.NextDouble() < 0.4)
            {
                Hibernating = false;
            }

            if (!Hibernating)
            {
                Console.WriteLine("Roaaaaaaaaaaaarrr!!!");
            }
        }

        public bool TryEat(object objectToEat)
        {
            if (!Hibernating)
            {
                if (random.NextDouble() < 0.8)
                {
                    Console.WriteLine("Brown Bear is eating " + objectToEat);
                    return true;
                }
                else
                {
                    Console.WriteLine("Brown Bear was not able to eat " + objectToEat);
                    return false;
                }
            }

            return false;
        }

        public BrownBear()
        {
            random = new Random();
            Hibernating = random.NextDouble() < 0.5;
        }
    }
}