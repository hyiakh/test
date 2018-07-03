using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCoin : MonoBehaviour {

    public float tumble = 5f;

    // Use this for initialization
    void Start () {

        GetComponent<Rigidbody>().angularVelocity = 
            Random.insideUnitSphere * tumble;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
