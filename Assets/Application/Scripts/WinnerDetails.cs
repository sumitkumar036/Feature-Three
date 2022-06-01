using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerDetails : MonoBehaviour {
    public Text winnerText; //winner text to display winning text
    public int winnerWeightage; //to show total score
    public GameObject winnerpanel; //active banner once player wins the match
    public Image winnerImage; //winner jackpot image

    private void Awake () {

    }
    private void OnEnable () {
        GameManager.winnerIs += ShowDetails; //Subscribing winnerIs
    }

    private void OnDisable () {
        GameManager.winnerIs -= ShowDetails; //Unsubscribing winnerIs
    }

    public int count;
    /// <summary>
    /// This function is for showing winner score and congratulation text
    /// </summary>
    /// <param name="card">Winner jackpot</param>
    public void ShowDetails (CardData card) {
        winnerText.text = "Congratulation !! <color=green>\n" + card.cardName +
            " </color> has won the Game \n" + "Credit Point : <color=green>" + card.weightage + "</color>";

        winnerWeightage = card.weightage;
        winnerImage.sprite = card.sprite;

        if (winnerpanel != null)
            winnerpanel.SetActive (true); //Winner banner showing jackpot
    }

}