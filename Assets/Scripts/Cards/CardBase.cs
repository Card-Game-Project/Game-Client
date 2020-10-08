using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

// Base card class that every card will derive from
public abstract class CardBase
{
    // Abstract properties
    public abstract string Name { get; }    // The name of each card
    public abstract string Description { get; }    // The description of each card
    public abstract int Mana { get; }    // The ManaCost of each card.
    public abstract Enums.CardType CardType { get; }    // The type of each card
    public abstract Enums.Rarity Rarity { get; }
    public abstract List<AbilityConnection> Abilities { get; }   // The abilities that each card will have

    // Constructor
    public CardBase() { }
}
