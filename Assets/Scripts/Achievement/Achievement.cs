using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{
    private Image img;

    public enum AchievementTypes { Perfectwin, NormalWin, Lose}
    [SerializeField] private AchievementTypes achievementType;
    public AchievementTypes _achievementType {get{return achievementType;}}
   
    public bool isUnlocked { get; private set;}

    private void Awake() 
    {
        img = GetComponent<Image>();
        CheckIfAchievementIsUnlocked();
    }

    public void CheckIfAchievementIsUnlocked()
    {
        if (PlayerPrefs.GetInt(achievementType.ToString()) == 0)
        {
          img.color = Color.black;
        }
        else
        {
            img.color = Color.white;
        }
    }

    public void UnlockThisAchievement()
    {
        PlayerPrefs.SetInt(achievementType.ToString(), 1);
        Awake();
    }
}
