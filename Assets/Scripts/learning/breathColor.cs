using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breathColor : MonoBehaviour
{

    public float speed = 1.0f;
    public Color startColor;
    public Color EndColor;
    public bool repeatable = false;
    public float startTime;
    

	// Use this for initialization
	void Start ()
	{
	    startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update() 
        
	{
	    if (!repeatable)
	    {
	        float t = (Time.time - startTime) *2* speed;
	        GetComponent<Renderer>().material.color = Color.Lerp(startColor, EndColor, t);
	    }
	    else
	    {
	        float t = (Mathf.Sin(Time.time - startTime) *2* speed);
	        GetComponent<Renderer>().material.color = Color.Lerp(startColor, EndColor, t);
        }
	}

}
