using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonInfo : MonoBehaviour
{

    public int itemId;
    public TextMeshProUGUI priceTxt;
    public TextMeshProUGUI quantityTxt;
    public GameObject shopManager;

    void Start()
    {
        priceTxt.text = "Rp. " + shopManager.GetComponent<ShopManagerScript>().shopItems[2, itemId].ToString();
        quantityTxt.text = PlayerPrefsManager.instance.GetQuantityItemsWithId(itemId).ToString();
    }

    void Update()
    {
        priceTxt.text = "Rp. " + shopManager.GetComponent<ShopManagerScript>().shopItems[2, itemId].ToString();
        quantityTxt.text = PlayerPrefsManager.instance.GetQuantityItemsWithId(itemId).ToString();
    }
}
