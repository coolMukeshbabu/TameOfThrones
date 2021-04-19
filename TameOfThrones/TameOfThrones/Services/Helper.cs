using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones.Services
{
    public class Helper
    {
        public static List<Kingdom> GetKingdoms()
        {
            List<Kingdom> kingdoms = new List<Kingdom>();
            Kingdom space = new Kingdom("Space", new Emblem("Gorilla"));
            Kingdom land = new Kingdom("Land", new Emblem("Panda"));
            Kingdom water = new Kingdom("Water", new Emblem("Octopus"));
            Kingdom ice = new Kingdom("Ice", new Emblem("Mammoth"));
            Kingdom air = new Kingdom("Air", new Emblem("Owl"));
            Kingdom fire = new Kingdom("Fire", new Emblem("Dragon"));
            kingdoms.Add(space);
            kingdoms.Add(land);
            kingdoms.Add(water);
            kingdoms.Add(ice);
            kingdoms.Add(air);
            kingdoms.Add(fire);

            return kingdoms;
        }
    }
}
