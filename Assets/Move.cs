using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject player;
    public float speed = 20f;
    

    // Use this for initialization
    void Start () {

        GetComponent<Rigidbody>().velocity = transform.forward * speed;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
