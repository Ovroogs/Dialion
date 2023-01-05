using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public static class GlobalVaribles
{
    //public static Dictionary<string, Race> races = new Dictionary<string, Race>
    //{
    //    { "Human", new Race(damageModifier: 1f) },
    //    { "Mage", new Race(damageModifier: 2f) },
    //    { "Rogue", new Race(damageModifier: 1.5f) }
    //};

    public static Dictionary<enumRace, Race> races = new Dictionary<enumRace, Race>
    {
        { enumRace.Human, new Human() },
        { enumRace.Elona, new Human(2f, 2f, 1f, 1f, 1f) },
        { enumRace.Elyos, new Human(1.5f, 3f, 1f, 1f, 1f) }
    };

    static GlobalVaribles()
    {
        
    }
}