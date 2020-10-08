using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    public List<CardBase> DeckCards { get; }

    public Deck()
    {
        DeckCards = new List<CardBase>();
    }

    public void AddCard(CardBase card)
    {
        if (DeckCards.Count < 50)
        {
            DeckCards.Add(card);
        }
    }

    public void DeleteCard(int position)
    {
        if (DeckCards.Count > 0 && position < DeckCards.Count)
        {
            DeckCards.RemoveAt(position);
        }
    }

    public CardBase DrawCard()
    {
        if (DeckCards.Count > 0)
        {
            CardBase card = DeckCards[DeckCards.Count - 1];
            DeckCards.RemoveAt(DeckCards.Count - 1);

            return card;
        }
        else
        {
            return null;
        }

    }

    public void Shuffle()
    {

        int n = DeckCards.Count;

        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            CardBase value = DeckCards[k];
            DeckCards[k] = DeckCards[n];
            DeckCards[n] = value;
        }
    }
}
