using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;

public class Mage : Creature
{
    public override void statsCount()
    {
        int powerModifier = getPower(_levelPower);
        switch (_specialization)
        {
            case Specialization.Mystic:
            case Specialization.Thaumaturge:
            case Specialization.Psyker:
                _HP = powerModifier * 12 + _levelPower * (_strength + 4 * _endurance) / 4;
                break;
        }

        _HP = Mathf.RoundToInt(_HP * raceHPModifier());
    }
}
