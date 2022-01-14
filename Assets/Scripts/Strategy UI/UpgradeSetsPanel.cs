using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSetsPanel : MonoBehaviour
{
    
    public GameObject snackbars;
    public GameObject studio;
    public GameObject building;

    public void snackbarpanels(bool pilihan) 
    {
        snackbars.SetActive(pilihan);

        // False
        studio.SetActive(false);
        building.SetActive(false);
    }

    public void studiopanels(bool pilihan) 
    {
        studio.SetActive(pilihan);

        // False
        snackbars.SetActive(false);
        building.SetActive(false);
    }

    public void buildingpanels(bool pilihan) 
    {
        building.SetActive(pilihan);

        // False
        studio.SetActive(false);
        snackbars.SetActive(false);
    }

}
