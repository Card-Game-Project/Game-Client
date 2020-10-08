using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public abstract class Ability
{
    // Abstract properties
    public abstract string Name { get; }
    public abstract string Description { get; }
    public abstract bool Choice { get; }

    // Blank constructor
    public Ability() { }

    // On ability trigger
    public abstract void Trigger(GameObject playerSide, GameObject enemySide);
}
