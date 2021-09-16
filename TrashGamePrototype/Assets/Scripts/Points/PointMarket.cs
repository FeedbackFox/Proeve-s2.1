using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Store system
/// </summary>
public class PointMarket : MonoBehaviour
{
    public GameObject ScriptManager;
    public GameObject MarketObject;
    //PointSystem pointSystem;

    public List<string> UnobtainedItems = new List<string>();
    public List<string> ObtainedItems = new List<string>();

    private void Start()
    {
        //pointSystem = MarketObject.GetComponent<PointSystem>();
        UnobtainedItems.Add("Kleur: rood");
        UnobtainedItems.Add("Kleur: blauw");
        UnobtainedItems.Add("kleur: zwart");
        ObtainedItems.Add("Kleur: rood");
        ObtainedItems.Add("Kleur: blauw");
        ObtainedItems.Add("kleur: zwart");
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
                Debug.Log(i);
            }
        }
    }

    //Buys the item
    public void BuyItem(int _itemNumber)
    {
        Debug.Log(UnobtainedItems[_itemNumber].ToString() + " gekocht");
        ObtainedItems.Add(UnobtainedItems[_itemNumber]);
        UnobtainedItems.Remove(UnobtainedItems[_itemNumber]);
        //CheckLists();
        gameObject.GetComponent<PointSystem>().RemovePoints(100);
    }

    public void OpenMarket()
    {
        MarketObject.SetActive(true);
    }

    public void CloseMarket()
    {
        MarketObject.SetActive(false);
    }
}