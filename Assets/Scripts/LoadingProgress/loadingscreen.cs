using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadingscreen : MonoBehaviour
{
    public Image loadingfill;
    public string target;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Loading());
    }

    IEnumerator Loading() {
        AsyncOperation loading = SceneManager.LoadSceneAsync(target);

        while(!loading.isDone){
            loadingfill.fillAmount = loading.progress/0.9f;
            yield return null;
        }
    }
}
