using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMobil : MonoBehaviour
{

    public GameObject[] prefabPool;
    private int randomPrefab;
    public Transform spawnPos;
    private float spawnTime = 10f;
    // Start is called before the first frame update

    void Start()

    {

        Spawn();
        InvokeRepeating("Spawn", spawnTime, spawnTime);

    }
    IEnumerator SetCarWhenOut(float time, GameObject Mobil)
    {
        yield return new WaitForSeconds(time);
        Mobil.SetActive(false);
        yield return new WaitForSeconds(5);
        Mobil.GetComponent<BoxCollider2D>().enabled = false;
        Mobil.SetActive(true);
        Mobil.GetComponent<CarController>().EmotFeedback.SetActive(true);
        Mobil.GetComponent<CarController>().MoveCar();
        yield return new WaitForSeconds(10);
        Mobil.GetComponent<BoxCollider2D>().enabled = true;

    }
    public void CallIE(GameObject Mobil)
    {
        StartCoroutine(SetCarWhenOut(2, Mobil));
    }
    void Spawn()
    {
        randomPrefab = Random.Range(0, prefabPool.Length);
        Instantiate(prefabPool[randomPrefab], spawnPos.position, spawnPos.rotation);
    }


}
