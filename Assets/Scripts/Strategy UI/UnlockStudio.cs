using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockStudio : MonoBehaviour
{
    public GameObject Item_Unlocks1;
    public void Unlocks()
    {
        Item_Unlocks1.SetActive(true);
    }
}
