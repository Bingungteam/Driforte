using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JarMoney : MonoBehaviour
{
    TextMeshProUGUI text;
    public static int Totalmoney;

    // Start is called before the first frame update
    void Start()
    {
        Totalmoney = 0;
        text = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Totalmoney.ToString();
    }
}
