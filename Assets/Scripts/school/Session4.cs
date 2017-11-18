using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4 : MonoBehaviour
{

    //Varibles
    public GameObject columnPrefab;
    IEnumerator creatColumnCoroutine;
    


	// Use this for initialization
	void Start ()
    {
        creatColumnCoroutine = Dropcolumn();
      
    }
	
	// Update is called once per frame
	void Update ()
    {
        StartCoroutine(creatColumnCoroutine);
        Debug.Log(Time.time);
        if (Time.time > 5)
        {
            StopCoroutine(creatColumnCoroutine);
            StopAllCoroutines();

        }
    }


    // Coroutines
    IEnumerator Dropcolumn()
    {
        while (true)
        {
         Vector3 columnPosition = new Vector3(Random.Range(-5f, 3f), Random.Range(-8f, 15f),Random.Range(-7f,0f));
         Quaternion columnRotation = new Quaternion(Random.Range(0f,90f), Random.Range(0f, 90f), Random.Range(0f,90f), 1);
         GameObject newColumn = Instantiate(columnPrefab, columnPosition, columnRotation);
         
         newColumn.GetComponent<Renderer>().GetComponentsInChildren<Renderer>()[1].material.color = new Color32(187, 25, 134, 255);
         newColumn.GetComponent<Renderer>().GetComponentsInChildren<Renderer>()[0].material.color = new Color32(255, 118, 195, 255);
         newColumn.GetComponent<Renderer>().GetComponentsInChildren<Renderer>()[2].material.color = new Color32(255, 0, 134, 255);
         
         yield return new WaitForSeconds(1);
        }

    }
}
