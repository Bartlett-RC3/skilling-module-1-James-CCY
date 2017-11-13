using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2homework : MonoBehaviour
{

    // Variables
    public bool myfriends = true;
    int avaiableDrinkTime;





    // Use this for initialization
    void Start()
    {

        // Conditionals

        // Short if statement
        if (myfriends)
        {
            Debug.Log("They like red wine");
        }
        else
        {
            Debug.Log("They do not like red wine");
        }

        avaiableDrinkTime = (myfriends == true) ? 20171114 : 0;
        Debug.Log("We like red wine and let's go at : " + avaiableDrinkTime);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
