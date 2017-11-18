using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMPingStar : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

    }


    //Varibles
    public GameObject CubestarPrefab;
    IEnumerator creatCubestarCoroutine;


    // Use this for initialization
    void Start ()
    {
        
       /* creatCubestarCoroutine = DropCubestar(); */
        creatCubestarCoroutine = FlyCubestar();

    }
	
	// Update is called once per frame
	void Update ()
    {
        StartCoroutine(creatCubestarCoroutine);
       
    }

    // Coroutines
   /* IEnumerator DropCubestar()
    {
        while (true)
        {
            Vector3 CubestarPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 20f), Random.Range(-20f, 10f));
            Quaternion CubestarRotation = new Quaternion(Random.Range(0f, 90f), Random.Range(0f, 90f), Random.Range(0f, 90f), 1);
            GameObject newCubestar = Instantiate(CubestarPrefab, CubestarPosition, CubestarRotation);

            newCubestar.GetComponent<Renderer>().GetComponentsInChildren<Renderer>()[1].material.color = new Color32(46, 157, 142, 255);
            newCubestar.GetComponent<Renderer>().GetComponentsInChildren<Renderer>()[0].material.color = new Color32(46, 82, 177, 255);
            newCubestar.GetComponent<Renderer>().GetComponentsInChildren<Renderer>()[2].material.color = new Color32(0, 31,84, 255);

            yield return new WaitForSeconds(5);
        }
    }*/

    IEnumerator FlyCubestar()
    {
        while (true)
        {
            Vector3 CubestarPosition = new Vector3(Random.Range(10f, -10f), Random.Range(10f, -20f), Random.Range(20f, -10f));
            Quaternion CubestarRotation = new Quaternion(Random.Range(90f,0f), Random.Range(90f, 0f), Random.Range(90f, 0f), 1);
            GameObject newCubestar = Instantiate(CubestarPrefab, CubestarPosition, CubestarRotation);

            newCubestar.GetComponent<Renderer>().GetComponentsInChildren<Renderer>()[1].material.color = new Color32(46, 157, 142, 255);
            newCubestar.GetComponent<Renderer>().GetComponentsInChildren<Renderer>()[0].material.color = new Color32(46, 82, 177, 255);
            newCubestar.GetComponent<Renderer>().GetComponentsInChildren<Renderer>()[2].material.color = new Color32(0, 31, 84, 255);
            newCubestar.GetComponent<Renderer>().GetComponentsInChildren<Renderer>()[3].material.color = new Color32(255, 118, 195, 255);


            yield return new WaitForSeconds(10);
        }
    }
}
