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

    public Text NotificationText;

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
    public void BuyItem(string _itemNumber)
    {
        string i = _itemNumber;
        Debug.Log(i);
        ObtainedItems.Add(i);
        UnobtainedItems.Remove(i.ToString());
        if (gameObject.GetComponent<PointSystem>()._obtainedPoints > 100)
        {
            gameObject.GetComponent<PointSystem>().RemovePoints(100);
        } else
        {
            Debug.Log("Can not buy");
        }
    }

    public void OpenMarket()
    {
        gameObject.GetComponent<Inventory>().inventoryObject.SetActive(false);
        MarketObject.SetActive(true);
    }

    public void CloseMarket()
    {
        MarketObject.SetActive(false);
    }
}