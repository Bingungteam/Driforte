using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollactivated : MonoBehaviour
{
    public GameObject scroll;

    public void scrolling_object(bool value)
    {
        scroll.SetActive(value);
    }
}
