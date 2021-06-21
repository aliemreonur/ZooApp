using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text title;
    public Text description;
    public Text exhibit;
    public Image animalImg;

    public CardModel[] cards;

    public void callSelectedCard(int i)
    {
        title.text = cards[i].title;
        description.text = cards[i].description;
        exhibit.text = cards[i].exhibit;
        animalImg.sprite = cards[i].animalImg;

    }

}
