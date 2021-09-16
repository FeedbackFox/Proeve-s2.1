using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    PointMarket pointMarket;
    List<string> ShownItems = new List<string>();
    public Text textPrefab;
    public GameObject location;
    public GameObject inventoryObject;

    public void OpenInventory()
    {
        inventoryObject.SetActive(true);
        foreach (string str in pointMarket.ObtainedItems)
        {
            int i = 1;
            Instantiate(textPrefab, new Vector3(location.transform.position.x, location.transform.position.y + (i * 10), location.transform.position.z), Quaternion.identity);
            textPrefab.name = textPrefab + i.ToString();
            textPrefab.text = str;
            ShownItems.Add(textPrefab.ToString());
            i++;
        }
    }

    public void CloseInventory()
    {

    }

}