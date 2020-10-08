using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class CardMinion : CardBase
{
    // Overrides
    public override string Name { get; }
    public override string Description { get; }
    public override int Mana { get; }
    public override Enums.CardType CardType { get; }
    public override Enums.Rarity Rarity { get; }
    public override List<AbilityConnection> Abilities { get; }

    // Member variables
    public int Attack { get; }    // The attack rating of the minion
    public int Defense { get; }    // The defense rating of the minion

    // Constructor (for minions with abilities)
    public CardMinion(string name, string description, int mana, Enums.CardType cardType, List<AbilityConnection> abilities, Enums.Rarity rarity, int attack, int defense)
    {
        this.Name = name;
        this.Description = description;
        this.Mana = mana;
        this.CardType = cardType;
        this.Rarity = rarity;
        this.Attack = attack;
        this.Defense = defense;

        // Check if we're inserting any abilities. If we are, good, if not, set this.abilities to null
        if (abilities.Count > 0)
        {
            this.Abilities = abilities;
        }
        else
        {
            this.Abilities = null;
        }
    }
}
