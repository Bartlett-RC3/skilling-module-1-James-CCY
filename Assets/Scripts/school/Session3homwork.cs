using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3homwork : MonoBehaviour
{
    // Variables
    int counter = 0;
    public GameObject cubeReference;
    bool moveup = true;
    bool moveright = true;
    bool movedown = true;
    bool moveleft = true;

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    // Use this for initialization
    void Start()
    {
        /*
        float speed = 50;
        this.transform.Translate(0f,(speed * Time.deltaTime ),0f,Space.World);
        
        if (Input.GetKey(KeyCode.UpArrow))
           this. transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
           this. transform.Translate(Vector3.right * turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            this. transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            this. transform.Translate(Vector3.left* turnSpeed * Time.deltaTime);*/


    }

    // Update is called once per frame
    void Update()
    {


        if (moveup == true)
        {
            if (counter <= 20)
            {
                this.gameObject.GetComponent<Transform>().position = new Vector3(-10, counter * 1, 0);
                counter++;
            }

            else
            {
                moveup = false;
                moveright = true;
                moveleft = false;
                movedown = false;
                counter = 1;
            }
        }
        if (moveright == true)
        {
            if (counter <= 20)
            {
                this.gameObject.GetComponent<Transform>().position = new Vector3(counter * 1, 20, 0);
                counter++;
            }
            else
            {
                moveup = false;
                moveright = false;
                moveleft = false;
                movedown = true;
                counter = 1;
            }
        }
        if (movedown == true)
        {
            if (counter <= 10)
            {
                this.gameObject.GetComponent<Transform>().position = new Vector3(20, counter * -1, 0);
                counter++;
            }
            else
            {
                moveup = false;
                moveright = false;
                moveleft = true;
                movedown = false;
                counter = 1;
            }
        }
        if (moveleft == true)
        {
            if (counter <= 20)
            {
                this.gameObject.GetComponent<Transform>().position = new Vector3(counter * -1, -10, 0);
                counter++;
            }
            else
            {
                moveup = true;
                moveright = false;
                moveleft = false;
                movedown = false;
                counter = 1;
            }
        }
        if (moveup == true)
        {
            if (counter <= 0)
            {
                this.gameObject.GetComponent<Transform>().position = new Vector3(0, counter * 1, 0);
                counter++;
            }

            else
            {
                moveup = false;
                moveright = true;
                moveleft = false;
                movedown = false;
                counter = 1;
            }
        }
    }
}
