using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPerfsManager : MonoBehaviour
{
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }

    public int AddDropdown(int add)
    {
        return PlayerPrefs.GetInt("addit" + add);
    }

    public int SetDropdown(int add, int txt)
    {
        PlayerPrefs.SetInt("addit" + add, txt);
        return AddDropdown(add);
    }
}
