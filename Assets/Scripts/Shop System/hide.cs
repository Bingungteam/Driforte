using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour
{
    public GameObject[] Objek;


    // Start is called before the first frame update
    void Start()
    {
        Hide(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hide(int Menghilang)
    {
        

        for (int i = 0; i < Objek.Length; i++)
        {
            Objek[i].SetActive(false);
            Debug.Log("Creating Object number: " + i);
        }

        Objek[Menghilang].SetActive(true);
    }
}
