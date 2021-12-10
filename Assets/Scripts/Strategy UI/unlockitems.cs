using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockitems : MonoBehaviour
{
    public GameObject Item_Unlocks1;
    public GameObject Item_Unlocks2;

    public void Unlocks()
    {
        Item_Unlocks1.SetActive(true);
        Item_Unlocks2.SetActive(true);
    }
}
