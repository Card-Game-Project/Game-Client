using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enums
{
    public enum AbilityType
    {
        ON_PLACE,
        ON_PLAYER_TURN_END,
        ON_ENEMY_TURN_END,
        ON_TURN_END,
        ON_DESTROY,
        ON_KILL
    }

    public enum CardType
    {
        MINION,
        SPELL,
        CHAMPION,
        TRAP
    }

    public enum Rarity
    {
        COMMON,
        UNCOMMON,
        RARE,
        EPIC,
        LEGENDARY
    }

    class EnumOutput
    {
        public static string CardTypeOutput(CardType cardType)
        {
            switch (cardType)
            {
                case CardType.MINION:
                    return "Minion";
                case CardType.SPELL:
                    return "Spell";
                case CardType.CHAMPION:
                    return "Champion";
                case CardType.TRAP:
                    return "Trap";
            }

            return "N/A";
        }
    }
}
