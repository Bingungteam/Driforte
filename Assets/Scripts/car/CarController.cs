using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D car;
    public SpawnerMobil spawn;
    public Animator anim;
    public float speed;
    public GameObject balonChar;
    public GameObject EmotFeedback;
   
    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        StartCoroutine(HideBaloon(3));
        spawn = GameObject.Find("Gameplay/SpawnController").GetComponent<SpawnerMobil>();
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
            StartCoroutine(NextMovement(5));

        }
        if (collision.gameObject.tag == "theatre")
        {
            speed = 0f;
            spawn.CallIE(this.gameObject);
            
            

        }
        if (collision.gameObject.name == "Destroyer")
        {
            Destroy(gameObject);
        }
    }
    public void MoveCar()
    {
        StartCoroutine(NextMovement(7));
    }


    IEnumerator NextMovement(float time)
    {
        yield return new WaitForSeconds(time);
        speed = 5f;
        anim.enabled = true;
    }
    IEnumerator HideBaloon(float time)
    {
        yield return new WaitForSeconds(time);
        balonChar.SetActive(false);

    }
}
