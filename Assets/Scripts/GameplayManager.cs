using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public GameObject gameplay;
    public GameObject buttonLeft;
    public GameObject buttonRight;
    
    public GameObject strategyUI;
    // Start is called before the first frame update
    void Start()
    {
        gameplay.SetActive(false);
        buttonLeft.SetActive(false);
        buttonRight.SetActive(false);
        strategyUI.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
