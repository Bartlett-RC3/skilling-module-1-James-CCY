using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE03HM : MonoBehaviour
{
    // Variables
    int counter = 0;
    public GameObject cubeReference;
    bool moveup = true;
    bool moveright = false ;
    bool movedown = false;
    bool moveleft = false;

    

    // Update is called once per frame
    void Update()
    {
      
        if (moveup == true)
        {
            if (counter <= 20)
            {
                gameObject.transform.Translate(Vector3.up);
                GetComponent<Renderer>().material.color = new Color(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                counter++;

            }

            else
            {
                moveup = false;
                moveright = true;
                counter = 0;  
            }
        }
        if (moveright == true)
        {
            if (counter <= 20)
            {
                gameObject.transform.Translate(Vector3.right);
                GetComponent<Renderer>().material.color = new Color(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                counter++;
            }
            else
            {
                moveright = false;
                movedown = true;
                counter = 0;
            }
        }
        if (movedown == true)
        {
            if (counter <= 20)
            {
                gameObject.transform.Translate(Vector3.down);
                GetComponent<Renderer>().material.color = new Color(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                counter++;
            }
            else
            {
                moveleft = true;
                movedown = false;
                counter = 0;
            }
        }
        if (moveleft == true)
        {
            if (counter <= 20)
            {
                gameObject.transform.Translate(Vector3.left);
                GetComponent<Renderer>().material.color = new Color(Random.Range(0.1f, 1f), Random.Range(0.1f, 1f), Random.Range(0.1f, 1f));
                counter++;
            }
            else
            {
                moveup = true;
                moveleft = false;
                counter = 0;
            }
        }
        
    }
}
