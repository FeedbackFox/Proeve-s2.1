using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Store system
/// </summary>
public class PointMarket : MonoBehaviour
{
    public List<string> UnobtainedItems = new List<string>();
    public List<string> ObtainedItems = new List<string>();

    private void Start()
    {
        UnobtainedItems.Add("Kleur: rood");
        UnobtainedItems.Add("Kleur: Blauw");
        UnobtainedItems.Add("kleur: Zwart");
        //CheckLists();
    }

    //Checks if the unobtaineditems list contains any items from the obtaineditems list and removes them
    void CheckLists()
    {
        for (int i = 0; i < ObtainedItems.Count; i++)
        {
            if (UnobtainedItems.Contains(ObtainedItems[i]))
            {
                UnobtainedItems.Remove(UnobtainedItems[i]);
            }
        }
    }

    //Buys the item
    public void BuyItem(string _itemName, int price, Button button)
    {
        UnobtainedItems.Remove(_itemName);
        ObtainedItems.Add(_itemName);
        Debug.Log(_itemName + " gekocht");
        CheckLists();
        button.enabled = false;
    }

}