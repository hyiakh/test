using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : MonoBehaviour {

   

    void Start()
    {
       
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
            FindObjectOfType<Score02>().AddPoint(10);
            Destroy(gameObject);


        

    }



    void Update () {
		
	}
}
