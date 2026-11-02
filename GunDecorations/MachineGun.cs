using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class MachineGun : Gun
    {
        public override int AmmoCapacity => 150;
        public override float NoiseLevel => 40.0f;
    }
}