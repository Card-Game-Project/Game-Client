using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class CardFactory
{
    public static CardBase CreateMinion(string name, string description, int mana, List<AbilityConnection> abilities, Enums.Rarity rarity, int attack, int defense)
    {
        return new CardMinion(name, description, mana, Enums.CardType.MINION, abilities, rarity, attack, defense);
    }
}
