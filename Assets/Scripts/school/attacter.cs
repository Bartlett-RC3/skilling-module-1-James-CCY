using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacter : MonoBehaviour {

    float speed = 1;
    
	// Use this for initialization
	void Start () {
        speed += Random.Range(0f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
