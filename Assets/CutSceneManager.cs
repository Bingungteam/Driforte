using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneManager : MonoBehaviour
{
    public GameObject[] CutSceneObjek;
    private int index = 0;
    public GameObject FinishButton;



  
    // Start is called before the first frame update
    void Start()
    {
        FinishButton.SetActive(false);
    }

    public void nextbutton()
    {
        index++;
        if (index > CutSceneObjek.Length -2)
        {
            FinishButton.SetActive(true);
        }
        index = Mathf.Clamp(index, 0, CutSceneObjek.Length -1);
        for (int i = 0; i < CutSceneObjek.Length; i++)
        {
            CutSceneObjek[i].gameObject.SetActive(false);
        }
        Debug.Log(index);
        CutSceneObjek[index].gameObject.SetActive(true);
        
    }

    public void prevbutton()
    {
        index--;
        if (index < CutSceneObjek.Length -1)
        {
            FinishButton.SetActive(false);
        }
        index = Mathf.Clamp(index, 0, CutSceneObjek.Length - 1);
        for (int i = 0; i < CutSceneObjek.Length; i++)
        {
            CutSceneObjek[i].gameObject.SetActive(false);
        }
        Debug.Log(index);
        CutSceneObjek[index].gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
