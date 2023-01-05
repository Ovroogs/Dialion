using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;

public class Rogue : Creature
{
    public override void statsCount()
    {
        int powerModifier = getPower(_levelPower);
        _HP = _levelPower * _strength - 3 * _levelPower;
        switch (_specialization)
        {
            case Specialization.Fighter:
                _HP += powerModifier * 12 + _levelPower * (_strength + 2 * _endurance) * (_level - 1) / 2;
                break;
            case Specialization.Archer:
            case Specialization.Thaumaturge:
                _HP += powerModifier * 12 + _levelPower * (_strength + 4 * _endurance) * (_level - 1) / 4;
                break;
            case Specialization.BattleMaster:
                _HP += powerModifier * 10 + _levelPower * (_strength + 4 * _endurance) * (_level - 1) / 3;
                break;
        }

        _HP = Mathf.RoundToInt(_HP * raceHPModifier());
    }
}
