using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data Card", menuName = "Create card", order = 1)]
public class CardData : ScriptableObject
{
    public string cardName;
    public Sprite sprite;
    public int weightage;
    public int pickChance;
    public int totalScore;
    public int totalWin;
}
