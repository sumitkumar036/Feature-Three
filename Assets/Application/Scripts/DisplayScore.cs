using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {
    public Text scoreText;
    private string gameObjectName;

    public GameData gameData;

    private void Awake () {
        gameObjectName = this.GetComponent<Transform> ().gameObject.name;

        for (var i = 0; i < gameData.cardData.Count; i++) {
            if (gameObjectName.Equals (gameData.cardData[i].cardName)) {
                scoreText.text = gameData.cardData[i].totalScore.ToString ();
            }
        }
    }

    private void OnEnable () {
        GameManager.winnerIs += Display;
    }

    private void OnDisable () {
        GameManager.winnerIs -= Display;
    }

    public void Display (CardData cardData) {
        if (gameObjectName.Equals (cardData.cardName))
            scoreText.text = cardData.totalScore.ToString ();

        else {
            return;
        }
    }
}