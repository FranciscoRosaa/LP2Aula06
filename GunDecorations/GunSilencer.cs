using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {
        
        public override float NoiseLevel => base.NoiseLevel - (base.NoiseLevel * (80 / 100.0f));

        public GunSilencer(Gun decoratedGun) : base(decoratedGun)
        {
        }
    }
}