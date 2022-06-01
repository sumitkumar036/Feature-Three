using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int mini, minor, major, grand;
    private int miniTotalWin, minorTotalWin, majorTotalWin, grandTotalWin;

    public GameData gameData;
    public delegate void WinnerIs (CardData cardData);
    public static WinnerIs winnerIs;

    private void Awake () 
    {
        winnerIs = null;
    }

    private void OnEnable()
    {
        ScriptableReference.clickedButton += CountEachSelected;
    }

    private void OnDisable()
    {
        ScriptableReference.clickedButton -= CountEachSelected;
    }

    public void CountEachSelected (CardData data) {
        switch (data.cardName) {
            case "Mini":
                mini += 1;
                if (mini == 3) {
                    miniTotalWin++;
                    WinnerDetail (data, miniTotalWin);
                    SavingGameData (data, 0, miniTotalWin);

                }
                break;

            case "Minor":
                minor += 1;
                if (minor == 3) {
                    minorTotalWin++;
                    WinnerDetail (data, minorTotalWin);
                    SavingGameData (data, 1, minorTotalWin);
                }
                break;

            case "Major":
                major += 1;
                if (major == 3) {
                    majorTotalWin++;
                    WinnerDetail (data, majorTotalWin);
                    SavingGameData (data, 2, majorTotalWin);
                }
                break;

            case "Grand":
                grand += 1;
                if (grand == 3) {
                    grandTotalWin++;
                    WinnerDetail (data, grandTotalWin);
                    SavingGameData (data, 3, grandTotalWin);
                }
                break;

            default:
                break;
        }
    }

    public void WinnerDetail (CardData data, int totalWin) {
        data.totalScore += data.weightage;
        if (winnerIs != null) {
            winnerIs (data);
        }
    }

    public void SavingGameData (CardData cardData, int number, int totalWin) {
        cardData.totalWin = totalWin;

        gameData.allData[number].cardName = cardData.cardName;
        gameData.allData[number].totalscore = cardData.totalScore;
        gameData.allData[number].totalWin = cardData.totalWin;
    }
}