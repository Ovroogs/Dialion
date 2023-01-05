using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Creature
{
    public override void statsCount()
    {
        const int enduranceMultiplier = 4;
        const float _lpClassModifier = 1f;

        int powerModifier = getPower(_levelPower);

        _HP = _levelPower * (_strength + enduranceMultiplier * _endurance);

        _minDamage = _strength * _levelPower * (1 + _level / 15);
        _maxDamage = Mathf.RoundToInt(_levelPower * (_strength * (1 + 0.15f * _level) + 1));


        switch (_specialization)
        {
            case Specialization.Fighter:
                _HP = powerModifier * 15 + _HP * _level / 4;
                break;
            case Specialization.Archer:
                _HP = powerModifier * 14 + _HP * _level / 4;
                break;
            case Specialization.BattleMaster:
                _HP = powerModifier * 14 + _HP * (_level - 1) / 4;
                break;
            case Specialization.Thaumaturge:
                _HP = powerModifier * 14 + _HP * _level / 4;
                break;
        }
        _leadershipPoints = (_strength + _endurance + _dexterity + _intellect + _wisdom + _willPower);
        _leadershipPoints *= Mathf.RoundToInt(Mathf.Pow(2, powerModifier) * _lpClassModifier * raceLPModifier());
        _HP = Mathf.RoundToInt(_HP * raceHPModifier());
        _minDamage = Mathf.RoundToInt(_minDamage * raceDamageModifier());
        _maxDamage = Mathf.RoundToInt(_maxDamage * raceDamageModifier());
        Debug.Log(_specialization + ": " + _HP);
    }
}