using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D car;
   
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (speed > 0.1f)
        {
            car.AddForce(new Vector2(1f, 0f));
        }
    }
}
