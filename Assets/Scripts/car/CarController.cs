using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D car;
    public Animator anim;
    public float speed;
    private int bil = 0;
    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (speed > 0.1f)
        {

            car.velocity = transform.right * speed;
        }
        if (speed == 0f)
        {
            car.velocity = Vector2.zero;
            anim.enabled = false;
        }
        
    }
   
   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ticket")
        {
            speed = 0f;
           
            
                StartCoroutine(NextMovement());
        
        }
      
    }
    IEnumerator NextMovement()
    {
        yield return new WaitForSeconds(5);
        speed = 5f;
        anim.enabled = true;
    }
   
}
