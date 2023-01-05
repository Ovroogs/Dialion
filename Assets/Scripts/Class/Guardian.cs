using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;

public class Guardian : Creature
{
    public override void statsCount()
    {
        int powerModifier = getPower(_levelPower);
        _HP = _levelPower * (_strength + 2 * _endurance);
        switch (_specialization)
        {
            case Specialization.Fighter:
                _HP = powerModifier * 20 + _HP * _level / 2 + _levelPower * 10 * _endurance;
                break;
            case Specialization.Archer:
            case Specialization.Thaumaturge:
            case Specialization.BattleMaster:
                _HP = powerModifier * 19 + _HP * (_level - 1) / 2 + _levelPower * 5 * _endurance;
                break;
        }

        _HP = Mathf.RoundToInt(_HP * raceHPModifier());
    }
}
