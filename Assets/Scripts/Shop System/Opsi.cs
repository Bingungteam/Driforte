using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using TMPro;

public class Opsi : MonoBehaviour
{
    public GameObject PanelAction;
    public GameObject PanelAdventure;
    public GameObject PanelAnimation;
    public GameObject PanelBiography;
    public GameObject PanelComedy;
    public GameObject PanelCrime;
    public GameObject PanelDrama;
    public GameObject PanelFamily;
    public GameObject PanelFantasy;
    public GameObject PanelHistory;
    public GameObject PanelHorror;
    public GameObject PanelMusic;
    public GameObject PanelMusical;
    public GameObject PanelMystery;
    public GameObject PanelRomance;
    public GameObject PanelScifi;
    public GameObject PanelSport;
    public GameObject PanelThriller;
    public GameObject PanelWar;
    public GameObject PanelWestern;
    public GameObject PanelMovie;
    //public Button ButtonFnD;
    //private bool FnD = false;
    //public GameObject PanelFnD;

    public void dropdownfunction(int value)
    {
        if(value == 0)
        {
            PanelMovie.SetActive(true);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
            
        }
        if (value == 1)
        {
            PanelAction.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 2)
        {
            PanelAdventure.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 3)
        {
            PanelAnimation.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 4)
        {
            PanelBiography.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 5)
        {
            PanelComedy.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 6)
        {
            PanelCrime.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 7)
        {
            PanelDrama.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 8)
        {
            PanelFamily.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 9)
        {
            PanelFantasy.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 10)
        {
            PanelHistory.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 11)
        {
            PanelHorror.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 12)
        {
            PanelMusic.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 13)
        {
            PanelMusical.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 14)
        {
            PanelMystery.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 15)
        {
            PanelRomance.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 16)
        {
            PanelScifi.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 17)
        {
            PanelSport.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 18)
        {
            PanelThriller.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelWar.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 19)
        {
            PanelWar.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWestern.SetActive(false);
        }
        if (value == 20)
        {
            PanelWestern.SetActive(true);
            PanelMovie.SetActive(false);
            PanelAction.SetActive(false);
            PanelAdventure.SetActive(false);
            PanelAnimation.SetActive(false);
            PanelBiography.SetActive(false);
            PanelComedy.SetActive(false);
            PanelCrime.SetActive(false);
            PanelDrama.SetActive(false);
            PanelFamily.SetActive(false);
            PanelFantasy.SetActive(false);
            PanelHistory.SetActive(false);
            PanelHorror.SetActive(false);
            PanelMusic.SetActive(false);
            PanelMusical.SetActive(false);
            PanelMystery.SetActive(false);
            PanelRomance.SetActive(false);
            PanelScifi.SetActive(false);
            PanelSport.SetActive(false);
            PanelThriller.SetActive(false);
            PanelWar.SetActive(false);
        }
        
    }

    //public void ButtonFunction()
    //{
            //if (!FnD)
           // {
                //FnD = true;
               // PanelFnD.SetActive(true);
           // }

           // FnD = false;
            //PanelFnD.SetActive(false);
  
   // }
    
}