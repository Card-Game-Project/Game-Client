using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class AbilityConnection
{
    // Member properties
    public Ability Ability { get; }
    public Enums.AbilityType AbilityType { get; }

    // Constructor
    public AbilityConnection(Ability ability, Enums.AbilityType abilityType)
    {
        this.Ability = ability;
        this.AbilityType = abilityType;
    }
}
