using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropcolor : MonoBehaviour {

    bool moveup = true;
    bool moveright = true;
    bool movedown = true;
    bool moveleft = true;
    bool movedback = true;
    bool moveforward = true;
    


    public GameObject cubePrefab;
    IEnumerator creatcubeCoroutine;


    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = new Color32(0, 128, 209, 255);

        if (other.gameObject.GetComponent<Renderer>().material.color == new Color32(0, 128, 209, 255))
        {
            other.gameObject.transform.Translate(Vector3.forward * 3f);
        }
        else
        {
            other.gameObject.transform.Translate(Vector3.up * 5f);
        }
           
            
        if (moveforward == true )
        {
            other.gameObject.transform.Translate(Vector3.up * 5f);
            other.gameObject.GetComponent<Renderer>().material.color = new Color32(134, 128, 110, 255);
        }
    
    }

   // Use this for initialization
    void Start () {

        
        

        
    }

    // Coroutines
    IEnumerator Dropcube()
    {
        Vector3 cubePosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
        Quaternion cubeRotation = new Quaternion(Random.Range(0f, 90f), Random.Range(0f, 90f), Random.Range(0f, 90f), 1);
        GameObject newcube = Instantiate(cubePrefab, cubePosition, cubeRotation);
        newcube.GetComponent<Renderer>().GetComponentsInChildren<Renderer>()[1].material.color = new Color32(255, 255, 255, 255);

        yield return new WaitForSeconds(5);
    }

    // Update is called once per frame
    void Update ()

    {
        


    }
}
