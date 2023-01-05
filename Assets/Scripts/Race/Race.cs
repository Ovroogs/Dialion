using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum enumRace
{
    Human,
    Elona,
    Elyos,
    Undeath,
    Demon,
    Hollow,
    Automaton,
    Gnomes
}

public class Race
{
    public float DamageModifier { get; }
    public float HitPointModifier { get; }
    public float SoulPointModifier { get; }
    public float MindPointModifier { get; }
    public float LeadershipPointsModifier { get; }

    public Race(float damageModifier, float hpModifier, float spModifier, float mpModifier, float lpModifier)
    {
        DamageModifier = damageModifier;
        HitPointModifier = hpModifier;
        SoulPointModifier = spModifier;
        MindPointModifier = mpModifier;
        LeadershipPointsModifier = lpModifier;
    }

    public virtual void racialFeature()
    {

    }
}