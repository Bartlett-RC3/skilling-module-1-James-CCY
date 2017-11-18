using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UPtosurfaceDestory : MonoBehaviour {

    public GameObject CubestarPrefab;
    // Ontigger Collider

    void OnTrigger(Collider CubestarPrefab)
    {
        Destroy(CubestarPrefab.gameObject);
    }

    

    // Use this for initialization
    void Start () {

	    

	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(Time.time);
        if (Time.time > 5)
        {
            Destroy(CubestarPrefab.gameObject);

        }


    }
}
