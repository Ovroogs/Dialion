using System.Collections.Generic;

using UnityEngine;

public enum Fraction
{
    Kingdom,
    Dnoxes,
    Directory,
    OrderUnity,
    Empire,
    Deyska,
    EvilSpirits,
    Neutrals
}

public enum Specialization
{
    Fighter,
    Archer,
    BattleMaster,
    Thaumaturge,
    Mystic,
    Psyker
}

public abstract class Creature : MonoBehaviour
{
    [SerializeField] protected int _strength, _endurance, _dexterity, _intellect, _wisdom, _willPower;
    [Range(1,3)]
    [SerializeField] protected int _level;
    [Range(1, 5)]
    [SerializeField] protected int _levelPower;
    protected int _leadershipPoints, _initiative, _HP, _SP, _MP, _minDamage, _maxDamage, _DP, _crit, _critChance, _EP, _speed;
    protected Fraction _fraction;
    [SerializeField] protected enumRace _race;
    [SerializeField] protected Specialization _specialization;


    public abstract void statsCount();

    protected int getPower(int number)
    {
        if (number == 1) 
        { 
            return 1;
        }

        int result = number * getPower(number - 1);

        return number == 5 ? result / 2 : result;
    }

    protected float raceDamageModifier() => GlobalVaribles.races[_race].DamageModifier;

    protected float raceHPModifier() => GlobalVaribles.races[_race].HitPointModifier;

    protected float raceLPModifier() => GlobalVaribles.races[_race].LeadershipPointsModifier;
}