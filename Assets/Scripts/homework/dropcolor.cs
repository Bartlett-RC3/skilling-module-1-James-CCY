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
            other.gameObject.transform.Translate(Vector3.forward * 2f);
            
        if (other.gameObject.tag == "chagecolor")
        {
            this.gameObject.transform.Translate(Vector3.up * 5f);
            this.gameObject.GetComponent<Renderer>().material.color = new Color32(128, 0, 209, 255);
            creatcubeCoroutine = Dropcube();
            Destroy(other.gameObject);
        }
    
    }

   // Use this for initialization
    void Start () {

        
        

        
    }

    // Coroutines
    IEnumerator Dropcube()
    {
        Vector3 cubePosition = new Vector3(Random.Range(-5f, 3f), Random.Range(-8f, 15f), Random.Range(-7f, 0f));
        Quaternion cubeRotation = new Quaternion(Random.Range(0f, 90f), Random.Range(0f, 90f), Random.Range(0f, 90f), 1);
        GameObject newcube = Instantiate(cubePrefab, cubePosition, cubeRotation);

        yield return new WaitForSeconds(5);
    }

    // Update is called once per frame
    void Update ()

    {
        


    }
}
