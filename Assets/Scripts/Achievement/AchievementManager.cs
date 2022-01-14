using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager Instance;

    [SerializeField] private Achievement[] Condition;

    private void Awake()
    {

        Instance = this;
    }

    public void UnlockAchievement(Achievement.AchievementTypes achievementType)
    {
    
    }
 

}
