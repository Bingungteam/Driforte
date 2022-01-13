using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandPrices : MonoBehaviour
{
    public void GetProfit(int value)
    {
        JarMoney.Totalmoney += value;
        Debug.Log("Price : " + value.ToString());
    }
}
