using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE03HM : MonoBehaviour
{
    // Variables
    int counter = 0;
    public GameObject cubeReference;
    bool moveup = true;
    bool moveright = true;
    bool movedown = true;
    bool moveleft = true;

    public float moveSpeed = 10f;
    public float turnSpeed = 10f;

    

    // Update is called once per frame
    void Update()
    {
        // Move the cube up
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 0.01f);
        }

        // Move the cube down
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 0.01f);
        }

        if (moveup == true)
        {
            if (counter <= 20)
            {
                this.gameObject.GetComponent<Transform>().position = new Vector3(-30, counter * 1, 0);
                this.GetComponent<Renderer>().material.color = new Color32(232, 56, 40, 255);
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
                this.GetComponent<Renderer>().material.color = new Color32(243, 152, 0, 255);
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
                this.GetComponent<Renderer>().material.color = new Color32(34, 172, 56, 255);
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
                this.GetComponent<Renderer>().material.color = new Color32(3, 70, 157, 255);
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
                this.gameObject.GetComponent<Transform>().position = new Vector3(-30, counter * 1, 0);
                this.GetComponent<Renderer>().material.color = new Color32(232, 56, 40, 255);
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
