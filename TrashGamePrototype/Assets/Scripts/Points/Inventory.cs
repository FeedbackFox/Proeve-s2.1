using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    PointMarket pointMarket;
    public Text ItemText;
    public GameObject inventoryObject;

    public void OpenInventory()
    {
        inventoryObject.SetActive(true);
        foreach (string str in gameObject.GetComponent<PointMarket>().ObtainedItems)
        {
            ItemText.text = ItemText.text + str.ToString() + "\n";
        }
    }

    public void CloseInventory()
    {
        Destroy(ItemText);
        inventoryObject.SetActive(false);
    }
}