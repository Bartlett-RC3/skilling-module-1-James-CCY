using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tttesting : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    public GameObject CubestarPrefab;

    IEnumerator creatCubestarCoroutine;

    // Use this for initialization
    void Start()
    {

        /* creatCubestarCoroutine = DropCubestar(); */
        creatCubestarCoroutine = FlyCubestar();

    }
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(creatCubestarCoroutine);

    }

    IEnumerator FlyCubestar()
    {
        Vector3 CubestarPosition = new Vector3(Random.Range(10f, -10f), Random.Range(10f, -20f), Random.Range(20f, -10f));
        Quaternion CubestarRotation = new Quaternion(Random.Range(90f, 0f), Random.Range(90f, 0f), Random.Range(90f, 0f), 1);
        GameObject newCubestar = Instantiate(CubestarPrefab, CubestarPosition, CubestarRotation);
        yield return new WaitForSeconds(5);
    }
}