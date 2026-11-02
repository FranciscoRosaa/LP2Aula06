using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunClip : GunDecorator
    {
        public override int AmmoCapacity => base.AmmoCapacity + 50;

        public GunClip(Gun decoratedGun) : base(decoratedGun)
        {
        }
    }
}