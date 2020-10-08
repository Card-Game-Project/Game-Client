using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager C;

    // Card Prefabs to be instantiated
    public GameObject playerCardPrefab;
    public GameObject enemyCardPrefab;

    // The different areas where player hands will be
    public GameObject playerArea;
    public GameObject enemyArea;

    // The different fields where players will place cards
    public GameObject playerField;
    public GameObject enemyField;

    // Both player decks
    public Deck playerDeck = new Deck();
    public Deck enemyDeck = new Deck();

    // Both player hands
    public Hand playerHand = new Hand();
    public Hand enemyHand = new Hand();

    private void Start()
    {
        C = this;

        GameStart();
    }

    public void GameStart()
    {
        List<AbilityConnection> abilities = new List<AbilityConnection>();

        playerDeck.AddCard(CardFactory.CreateMinion("Alohai", "Some badass", 4, abilities, Enums.Rarity.COMMON, 400, 600));
        playerDeck.AddCard(CardFactory.CreateMinion("Dimerant", "Another Badass", 7, abilities, Enums.Rarity.UNCOMMON, 300, 500));
        playerDeck.AddCard(CardFactory.CreateMinion("Quinteef the Stricken", "Waow", 3, abilities, Enums.Rarity.COMMON, 100, 50));
        playerDeck.AddCard(CardFactory.CreateMinion("Klunikan", "Who r u", 4, abilities, Enums.Rarity.EPIC, 400, 1000));
        playerDeck.AddCard(CardFactory.CreateMinion("Duniken", "yeet", 1, abilities, Enums.Rarity.COMMON, 10, 20));
        playerDeck.AddCard(CardFactory.CreateMinion("Joey", "Some ordinary dude", 8, abilities, Enums.Rarity.LEGENDARY, 1000, 1000));
        playerDeck.AddCard(CardFactory.CreateMinion("Kuisee", "Hi", 4, abilities, Enums.Rarity.RARE, 400, 600));
        playerDeck.AddCard(CardFactory.CreateMinion("Yesss", "Snek", 5, abilities, Enums.Rarity.COMMON, 400, 600));
        playerDeck.AddCard(CardFactory.CreateMinion("Alohai2", "Some badass2", 6, abilities, Enums.Rarity.RARE, 300, 700));

        enemyDeck.AddCard(CardFactory.CreateMinion("Alohai", "Some badass", 4, abilities, Enums.Rarity.COMMON, 400, 600));
        enemyDeck.AddCard(CardFactory.CreateMinion("Dimerant", "Another Badass", 7, abilities, Enums.Rarity.UNCOMMON, 300, 500));
        enemyDeck.AddCard(CardFactory.CreateMinion("Quinteef the Stricken", "Waow", 3, abilities, Enums.Rarity.COMMON, 100, 50));
        enemyDeck.AddCard(CardFactory.CreateMinion("Klunikan", "Who r u", 4, abilities, Enums.Rarity.EPIC, 400, 1000));
        enemyDeck.AddCard(CardFactory.CreateMinion("Duniken", "yeet", 1, abilities, Enums.Rarity.COMMON, 10, 20));
        enemyDeck.AddCard(CardFactory.CreateMinion("Joey", "Some ordinary dude", 8, abilities, Enums.Rarity.LEGENDARY, 1000, 1000));
        enemyDeck.AddCard(CardFactory.CreateMinion("Kuisee", "Hi", 4, abilities, Enums.Rarity.RARE, 400, 600));
        enemyDeck.AddCard(CardFactory.CreateMinion("Yesss", "Snek", 5, abilities, Enums.Rarity.COMMON, 400, 600));
        enemyDeck.AddCard(CardFactory.CreateMinion("Alohai2", "Some badass2", 6, abilities, Enums.Rarity.RARE, 300, 700));

        playerDeck.Shuffle();
        enemyDeck.Shuffle();

        DealCards(5);
    }

    public void DealCards(int numCards)
    {
        for (int i = 0; i < numCards; i++)
        {
            GameObject newPlayercard = Instantiate(playerCardPrefab);

            newPlayercard.GetComponent<CardPrefab>().SetCard(playerDeck.DrawCard());

            newPlayercard.transform.SetParent(playerArea.transform.GetChild(1), false);
        }
    }

    public static void PlayCard(GameObject playedCard)
    {
        CardPrefab card = playedCard.GetComponent<CardPrefab>();

        card.isPlayed = true;

        playedCard.transform.GetChild(1).GetComponent<Image>().enabled = false;
        playedCard.transform.GetChild(2).GetComponent<Image>().enabled = true;

        playedCard.transform.SetParent(C.playerField.transform, false);
    }
}
