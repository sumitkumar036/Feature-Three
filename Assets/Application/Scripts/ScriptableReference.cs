using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof (Button))]
public class ScriptableReference : MonoBehaviour {
    public int[] commutativeProbability = { 50, 75, 95, 100 };
    public CardData cardData;
    public Image _buttonImage;
    public Button button;
    public GameData gameData;


    public delegate void ClickedButton (CardData data);
    public static ClickedButton clickedButton;

    private void Awake () {

        if (button == null)
            button = GetComponent<Button> ();

        if (_buttonImage == null)
            _buttonImage = button.GetComponent<Image> ();

        button.onClick.AddListener (delegate { ButtonClicked (button); });
    }

    
    private void ButtonClicked (Button btn) {
        cardData = gameData.cardData[GetRandomCardID()];
        _buttonImage.sprite = cardData.sprite;
        btn.interactable = false;

        if (clickedButton != null) {
            clickedButton (cardData);
        }
    }

    public int GetRandomCardID()
    {
        float rand = UnityEngine.Random.Range(0, 101);
        for (int i = 0; i < 4; i++)
        {
            if(rand <= commutativeProbability[i])
            {
                return i;
            }
        }
        
        return -1;
    }
}