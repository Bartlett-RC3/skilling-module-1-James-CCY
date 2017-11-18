using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHANGECOLORBYPRESS : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	    // Move the cube down
	    if (Input.GetKey(KeyCode.S))
	    {
	        transform.Translate(Vector3.down * 0.5f);
	        this.GetComponent<Renderer>().material.color = new Color32(232, 56, 40, 255);
        }

	    // Move the cube UP
	    if (Input.GetKey(KeyCode.W))
	    {
	        transform.Translate(Vector3.up * 0.5f);
	        this.GetComponent<Renderer>().material.color = new Color32(243, 152, 0, 255);
        }

	    // Move the cube left
	    if (Input.GetKey(KeyCode.A))
	    {
	        transform.Translate(Vector3.left * 0.5f);
	        this.GetComponent<Renderer>().material.color = new Color32(34, 172, 56, 255);
        }

	    // Move the cube righ
	    if (Input.GetKey(KeyCode.D))
	    {
	        transform.Translate(Vector3.right * 0.5f);
	        this.GetComponent<Renderer>().material.color = new Color32(3, 70, 157, 255);
        }
    }
}
