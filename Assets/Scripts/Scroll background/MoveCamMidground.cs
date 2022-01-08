using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamMidground : MonoBehaviour
    
{
    [SerializeField]
    private Transform midground;
    public float smoothing;
    public float Xmin;
    public float Xmax;
    
    public void ButtonRight()
    {
        MidGroundRight();   
    }
    public void ButtonLeft()
    {
        MidGroundleft();
    }
    void MidGroundRight()
    {   
            Vector3 targetPosition = new Vector3(Xmax, 0f,transform.position.z);
            transform.position = Vector3.Lerp
            (transform.position,
            targetPosition, smoothing * Time.deltaTime);
          
        
    }
    void MidGroundleft()
    {  Vector3 targetPosition = new Vector3(Xmin, 0f, transform.position.z);
        transform.position = Vector3.Lerp
        (transform.position,
        targetPosition, smoothing * Time.deltaTime);
       
    }
   
}
