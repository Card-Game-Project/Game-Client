using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CardPrefab : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    Vector3 originalScale;
    Vector3 originalPosition;

    Canvas canvas;

    public CardBase card;

    public bool isPlayed = false;
    public bool isDeck = false;

    private void Start()
    {
        originalScale = gameObject.transform.localScale;

        canvas = gameObject.GetComponent<Canvas>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!isDeck)
        {
            if (!isPlayed)
            {
                originalPosition = gameObject.transform.position;
                gameObject.transform.GetChild(0).Translate(new Vector3(0, Screen.height / 13, 0));
                gameObject.transform.localScale = new Vector3(4, 4, gameObject.transform.localScale.z);
                canvas.sortingOrder = 2;
            }
            else
            {
                gameObject.transform.localScale = new Vector3(4, 4, gameObject.transform.localScale.z);
                canvas.sortingOrder = 2;
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!isDeck && !isPlayed)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                gameObject.transform.localScale = new Vector3(2f, 2f, gameObject.transform.localScale.z);
                canvas.sortingOrder = 1;
                GameManager.PlayCard(this.gameObject);
            }
            else if (eventData.button == PointerEventData.InputButton.Right)
            {
                Debug.Log(card.Name);
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!isDeck)
        {
            if (!isPlayed)
            {
                gameObject.transform.GetChild(0).position = originalPosition;
                gameObject.transform.localScale = originalScale;
                canvas.sortingOrder = 1;
            }
            else
            {
                gameObject.transform.localScale = new Vector3(2f, 2f, gameObject.transform.localScale.z);
                canvas.sortingOrder = 1;
            }
        }
    }

    public void SetCard(CardBase newCard)
    {
        card = newCard;
        SetCardDetails();
    }

    public void SetCardDetails()
    {
        Transform cardArt = gameObject.transform.GetChild(0);
        cardArt.GetChild(2).GetComponent<TextMeshProUGUI>().text = card.Name;
        cardArt.GetChild(3).GetComponent<TextMeshProUGUI>().text = Enums.EnumOutput.CardTypeOutput(card.CardType);
        cardArt.GetChild(4).GetComponent<TextMeshProUGUI>().text = card.Description;
    }
}
