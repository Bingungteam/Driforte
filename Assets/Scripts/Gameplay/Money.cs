using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    //trigger object mobil agar mendapatkan keuntungan
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Tickets"))
        {
            StandPrices standPrices = collision.gameObject.GetComponent<StandPrices>();
            standPrices.GetProfit(20);
        }
        if (collision.transform.CompareTag("FnD"))
        {
            StandPrices standPrices = collision.gameObject.GetComponent<StandPrices>();
            standPrices.GetProfit(600);
        }
    }
    
}
