using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Store system
/// </summary>
public class PointMarket : MonoBehaviour
{

    public List<GameObject> UnobtainedItems = new List<GameObject>();
    public List<GameObject> ObtainedItems = new List<GameObject>();

    public void BuyItem(GameObject _itemName)
    {
        UnobtainedItems.Remove(_itemName);
        ObtainedItems.Add(_itemName);
        Debug.Log(_itemName.name + " gekocht");
    }

}