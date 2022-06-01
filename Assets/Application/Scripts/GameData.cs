using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Create Game Data", fileName = "Game Data")]
public class GameData : ScriptableObject 
{
    public List<CardData> cardData = new List<CardData>();
    public AllData[] allData;

}


[System.Serializable]
public class AllData {
    public string cardName;
    public int totalscore;
    public int totalWin;
}