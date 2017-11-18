using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCYmoveslow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	    // Move the cube down
	    if (Input.GetKey(KeyCode.S))
	    {
	        transform.Translate(Vector3.down * 0.2f);
	        this.GetComponent<Renderer>().material.color = new Color32(0, 128, 209, 255);
        }

	    // Move the cube UP
	    if (Input.GetKey(KeyCode.W))
	    {
	        transform.Translate(Vector3.up * 0.2f);
	        this.GetComponent<Renderer>().material.color = new Color32(0, 181, 255, 255);
        }

	    // Move the cube left
	    if (Input.GetKey(KeyCode.A))
	    {
	        transform.Translate(Vector3.left * 0.2f);
	        this.GetComponent<Renderer>().material.color = new Color32(0, 255, 255, 255);
        }

	    // Move the cube righ
	    if (Input.GetKey(KeyCode.D))
	    {
	        transform.Translate(Vector3.right * 0.2f);
	        this.GetComponent<Renderer>().material.color = new Color32(0, 30, 135, 255);
        }
	    
        // Move the cube foraword

	    if (Input.GetKey(KeyCode.E))
	    {
	        transform.Translate(Vector3.forward * 0.2f);
	        this.GetComponent<Renderer>().material.color = new Color32(126, 54, 179, 255);
	    }
	    // Move the cube backaword
        if (Input.GetKey(KeyCode.Q))
	    {
	        transform.Translate(Vector3.back * 0.2f);
	        this.GetComponent<Renderer>().material.color = new Color32(175, 0, 133, 255);
	    }
	    


    }
}
