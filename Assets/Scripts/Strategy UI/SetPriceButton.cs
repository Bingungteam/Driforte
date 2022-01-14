using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetPriceButton : MonoBehaviour
{
    public int Value = 100;
    public TextMeshProUGUI TextObject;

    //menambah harga berkelipatan 50
    public void Increment(){
        Value += 50;
        if (Value < 501)
        {
            TextObject.text = "Rp. " + Value.ToString();
        }
    }

    //mengurangi harga berkelipatan 50
    public void decrement()
    {
        Value -= 50;
        if (Value < 0)
        {
            Value = 0;
        }
        TextObject.text = "Rp. " +Value.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        TextObject.text = "Rp. " + Value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
