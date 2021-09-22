using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject qrScan;
    public GameObject menu;

    public void OpenQr()
    {
        qrScan.SetActive(true);
        menu.SetActive(false);
    }

    public void CloseQr()
    {
        qrScan.SetActive(false);
        menu.SetActive(true);
    }
}
