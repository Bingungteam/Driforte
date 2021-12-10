using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class actionbuttons : MonoBehaviour
{
    public GameObject startday;
    public GameObject guidebook;
    public GameObject StrategyPanel;

    public void startdaybutton(bool answer) 
    {
        startday.SetActive(answer);
        guidebook.SetActive(false);
        StrategyPanel.SetActive(false);
    }

    public void ke_toko()
    {
        SceneManager.LoadScene("ShopFeature");
    }
      public void ke_Strategy()
    {
        SceneManager.LoadScene("Strategy");
    }
        public void ke_Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ke_guidebook(bool answer) 
    {
        startday.SetActive(false);
        guidebook.SetActive(false);
        StrategyPanel.SetActive(false);
    }
}
