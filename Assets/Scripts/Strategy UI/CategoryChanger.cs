using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CategoryChanger : MonoBehaviour
{
    // Panel Category
    public GameObject film;
    public GameObject tiket;
    public GameObject promos;
    public GameObject snackbar;
    public GameObject upgrade;
    public GameObject diabaikansaatditekan;
    public bool pilihan;

    // Upgrade Variant Settings Panel
    public GameObject upgrade_snackbar;
    public GameObject upgrade_studio;
    public GameObject upgrade_building;
    public bool upgradechoice;
    
    public void setkategori(int nilai) 
    {
        if(nilai >= 1)
        {
            film.SetActive(pilihan);
            tiket.SetActive(false);
            promos.SetActive(false);
            snackbar.SetActive(false);
            upgrade.SetActive(false); 
            diabaikansaatditekan.SetActive(false); 
        }
        if(nilai >= 2)
        {
            film.SetActive(false);
            tiket.SetActive(pilihan);
            promos.SetActive(false);
            snackbar.SetActive(false);
            upgrade.SetActive(false); 
            diabaikansaatditekan.SetActive(false); 
        }
        if(nilai >= 3)
        {
            film.SetActive(false);
            tiket.SetActive(false);
            promos.SetActive(pilihan);
            snackbar.SetActive(false);
            upgrade.SetActive(false); 
            diabaikansaatditekan.SetActive(false); 
        }
        if(nilai >= 4)
        {
            film.SetActive(false);
            tiket.SetActive(false);
            promos.SetActive(false);
            snackbar.SetActive(pilihan);
            upgrade.SetActive(false); 
            diabaikansaatditekan.SetActive(false); 
        }
        if(nilai >= 5)
        {
            film.SetActive(false);
            tiket.SetActive(false);
            promos.SetActive(false);
            snackbar.SetActive(false);
            upgrade.SetActive(pilihan); 
            diabaikansaatditekan.SetActive(false); 
        }
    }

    public void upgrade_variant(int variant)
    {
        if(variant >= 1)
        {
            upgrade_snackbar.SetActive(upgradechoice);
            upgrade_studio.SetActive(false);
            upgrade_building.SetActive(false);
        }
        if(variant >= 2)
        {
            upgrade_snackbar.SetActive(false);
            upgrade_studio.SetActive(upgradechoice);
            upgrade_building.SetActive(false);
        }
        if(variant >= 3)
        {
            upgrade_snackbar.SetActive(false);
            upgrade_studio.SetActive(false);
            upgrade_building.SetActive(upgradechoice);
        }
    }
}
