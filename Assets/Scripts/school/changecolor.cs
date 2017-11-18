using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour {

    public GameObject Cylinder; 

    // Use this for initialization
    void Start ()
    {
    GetComponent<Renderer>().material.color = new Color32(165, 5, 5, 255);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

}
