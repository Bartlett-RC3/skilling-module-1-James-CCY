using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCRrandom : MonoBehaviour {

    public GameObject CollidergGameObject ;


    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        if (CollidergGameObject.gameObject.GetComponent<Renderer>().material.color == Color.blue)
        {
            CollidergGameObject.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else 
        {
            CollidergGameObject.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        

    }
    // Use this for initialization
    void Start ()
    {
    
    }

	
	// Update is called once per frame
	void Update ()
    {
	
	}

}
