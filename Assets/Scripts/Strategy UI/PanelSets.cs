using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSets : MonoBehaviour
{

    public GameObject Film;
    public GameObject Tiket;
    public GameObject Advertising;
    public GameObject Snackbar;
    public GameObject Upgrade;
    
    public void filmsets(bool pilihan) 
    {
        Film.SetActive(pilihan);

        // False
        Tiket.SetActive(false);
        Advertising.SetActive(false);
        Snackbar.SetActive(false);
        Upgrade.SetActive(false);
    }

    public void Tiketsets(bool pilihan) 
    {
        Tiket.SetActive(pilihan);

        // False
        Film.SetActive(false);
        Advertising.SetActive(false);
        Snackbar.SetActive(false);
        Upgrade.SetActive(false);
    }

    public void Ad_sets(bool pilihan) 
    {
        Advertising.SetActive(pilihan);

        // False
        Tiket.SetActive(false);
        Film.SetActive(false);
        Snackbar.SetActive(false);
        Upgrade.SetActive(false);
    }

    public void Snackset(bool pilihan) 
    {
        Snackbar.SetActive(pilihan);

        // False
        Tiket.SetActive(false);
        Advertising.SetActive(false);
        Film.SetActive(false);
        Upgrade.SetActive(false);
    }

    public void Upgrade_sets(bool pilihan) 
    {
        Upgrade.SetActive(pilihan);

        // False
        Tiket.SetActive(false);
        Advertising.SetActive(false);
        Snackbar.SetActive(false);
        Film.SetActive(false);
    }
}
