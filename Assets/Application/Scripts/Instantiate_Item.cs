using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Item : MonoBehaviour
{
    [SerializeField] private GameObject _item;
    [SerializeField] private int _totalCards;
    private void Awake()
    {
        InstantiateCard(_item);
    }

    public void InstantiateCard(GameObject item)
    {
        for (var i = 0; i < _totalCards; i++)
        {
            GameObject obj = Instantiate<GameObject>(item);
            obj.transform.SetParent(this.transform);
            obj.name = "Item_Number => " + i;
           // CalculatePickedChance._instance.cardDetails.DataAssignment(obj, _totalCards);
        }
    }
}
