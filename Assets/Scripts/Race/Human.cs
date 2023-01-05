using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Race
{
    public Human(float damageModifier = 1, float hpModifier = 1, float spModifier = 1, float mpModifier = 1, float lpModifier = 1) 
        : base(damageModifier, hpModifier, spModifier, mpModifier, lpModifier)
    {
    }

    public override void racialFeature()
    {

    }
}