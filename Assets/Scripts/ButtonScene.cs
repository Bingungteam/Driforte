using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScene : MonoBehaviour
{
    public string targetnya;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void kemanaaja()
    {
        SceneManager.LoadScene(targetnya);
    }
}
