using System;

namespace GunDecorations
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Gun gun = new MachineGun();
            Console.WriteLine(" === Basic Machine Gun === ");
            gun.Fire();

            gun = new GunClip(gun);
            Console.WriteLine(" === Machine Gun With Clip === ");
            gun.Fire();

            gun = new GunSilencer(gun);
            Console.WriteLine(" === Machine Gun With Silencer === ");
            gun.Fire();

            gun = new GunClip(new GunSilencer(gun));
            Console.WriteLine(" === Machine Gun With Clip and Silencer === ");
            gun.Fire();
        }
    }
}
