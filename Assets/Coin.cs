using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour {

    public GameObject coin;
    public Vector3 spawnValues = new Vector3(6, 0, 16);
    public int coinCount = 10;
    public float spawnWait = 0.75f;
    public float startWait = 1f;
    public float waveWait = 4f;
    

    

    // Use this for initialization
    void Start () {

        
        StartCoroutine(SpawnWaves());

    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        //while (true)
        //{
            for (int i = 0; i < coinCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x),
                    spawnValues.y, spawnValues.z);
                Instantiate(coin, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);
            }

        
        yield return new WaitForSeconds(waveWait);

        

        
    }

    

    }

    






      