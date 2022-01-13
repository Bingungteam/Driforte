using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideafterupgrade : MonoBehaviour
{
    // Gameobjek button
    public GameObject buttonhide;


    public void Hide_Buttons()
    {
        buttonhide.SetActive(false);
    }

}
