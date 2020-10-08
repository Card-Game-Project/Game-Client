using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand
{
    public List<CardPrefab> CardHand;

    public Hand()
    {
        this.CardHand = new List<CardPrefab>();
    }

    public void AddCard(CardBase card)
    {
        CardPrefab prefab = new CardPrefab();
        prefab.SetCard(card);
        CardHand.Add(prefab);
    }

    public CardBase PlayCard(int position)
    {
        if (position < CardHand.Count)
        {
            CardBase card = CardHand[position].card;
            CardHand.RemoveAt(position);
            return card;
        }
        else
        {
            return null;
        }
    }
}
