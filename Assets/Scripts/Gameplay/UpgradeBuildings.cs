using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeBuildings : MonoBehaviour
{
    public GameObject image;
    public GameObject OldImage;
    public InputField inputFieldName;

    public void UpgradeSnackbar1()
    {
        if (inputFieldName.text == "upbuild1")
            image.SetActive(false);
        else
            image.SetActive(true);
        Destroy(OldImage);
    }

    public void UpgradeSnackbar2()
    {
        if (inputFieldName.text == "upbuild2")
            image.SetActive(false);
        else
            image.SetActive(true);
        Destroy(OldImage);
        
    }

    public void UpgradeTicketStand1()
    {
        if (inputFieldName.text == "upbuild3")
            image.SetActive(false);
        else
            image.SetActive(true);
        Destroy(OldImage);
    }

    public void UpgradeTicketStand2()
    {
        if (inputFieldName.text == "upbuild4")
            image.SetActive(false);
        else
            image.SetActive(true);
        Destroy(OldImage);
    }

    public void UpgradeBioskop1()
    {
        if (inputFieldName.text == "upbuild5")
            image.SetActive(false);
        else
            image.SetActive(true);
        Destroy(OldImage);
    }

    public void UpgradeBioskop2()
    {
        if (inputFieldName.text == "upbuild6")
            image.SetActive(false);
        else
            image.SetActive(true);
        Destroy(OldImage);
    }
 
}
