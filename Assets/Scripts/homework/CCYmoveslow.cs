using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class CCYmoveslow : MonoBehaviour
{
    

    
    public Vector3 minScale;
    public Vector3 maxScale;
    public float speed = 2f;
    public float duration = 5f;
    public bool repeatable;
    public GameObject cube;
    private Vector3 cubeScale = new Vector3(0.1f,0.1f,0.1f);

   

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        transform.localScale += cubeScale;
    }

    IEnumerator Start()
    {
        minScale = transform.localScale;
        while (repeatable)
        {
            yield return RepeatLerp(minScale, maxScale, duration);
            yield return RepeatLerp(maxScale, minScale, duration);
        }
    }

    public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time)
    {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }
    }








    // Update is called once per frame
    void Update ()
    {

       // Move the cube down
        if (Input.GetKey(KeyCode.S))
	    {
	       
            transform.Translate(Vector3.down * 0.4f,Space.World);
	        this.GetComponent<Renderer>().material.color = new Color32(0, 128, 209, 255);
	        //gameObject.transform.Rotate(new Vector3(0, -5f, 0),speed*Time.deltaTime,Space.Self);
        }

	    // Move the cube UP
	    if (Input.GetKey(KeyCode.W))
	    {
	        
            transform.Translate(Vector3.up * 0.4f, Space.World);
	        this.GetComponent<Renderer>().material.color = new Color32(0, 51, 153, 255);
	        //gameObject.transform.Rotate(new Vector3(0, 5f, 0), speed * Time.deltaTime, Space.Self);
        }

	    // Move the cube left
	    if (Input.GetKey(KeyCode.A))
	    {
	        
            transform.Translate(Vector3.left * 0.4f, Space.World);
	        this.GetComponent<Renderer>().material.color = new Color32(0, 255, 255, 255);
	        //gameObject.transform.Rotate(new Vector3(0, 0, -5f), speed * Time.deltaTime, Space.Self);
        }

	    // Move the cube righ
	    if (Input.GetKey(KeyCode.D))
	    {
	        
            transform.Translate(Vector3.right * 0.4f, Space.World);
	        this.GetComponent<Renderer>().material.color = new Color32(0, 30, 135, 255);
	        //gameObject.transform.Rotate(new Vector3(0, 0, 5f), speed * Time.deltaTime, Space.Self);
        }
	    
        // Move the cube foraword

	    if (Input.GetKey(KeyCode.E))
	    {
	       
            transform.Translate(Vector3.forward * 0.4f, Space.World);
	        this.GetComponent<Renderer>().material.color = new Color32(126, 54, 179, 255);
	        //gameObject.transform.Rotate(new Vector3(5f, 0, 0), speed * Time.deltaTime, Space.Self);
        }
	    // Move the cube backaword
        if (Input.GetKey(KeyCode.Q))
	    {
	        
            transform.Translate(Vector3.back * 0.4f, Space.World);
	        this.GetComponent<Renderer>().material.color = new Color32(175, 0, 133, 255);
	        //gameObject.transform.Rotate(new Vector3(-5f, 0, 0), speed * Time.deltaTime, Space.Self);
        }
	    


    }
}
