using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetyangingindiondanoff : MonoBehaviour
{
    public GameObject data1;
    public GameObject data2;
    public GameObject data3;
    public GameObject data4;

    public bool pilihan1;
    public bool pilihan2;
    public bool pilihan3;
    public bool pilihan4;

    public void on_off_nya()
    {
        data1.SetActive(pilihan1);
        data2.SetActive(pilihan2);
        data3.SetActive(pilihan3);
        data4.SetActive(pilihan4);
    }
}
