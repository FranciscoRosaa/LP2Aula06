using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class ShotGun : Gun
    {
        public override int AmmoCapacity => 6;
        public override float NoiseLevel => 70.0f;
    }
}