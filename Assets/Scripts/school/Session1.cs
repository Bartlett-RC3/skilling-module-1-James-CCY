using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// where code lives;

public class Session1 : MonoBehaviour
{

    // 1.Variables
    // Scope -- Type -- Name -- Value
    // Numbers
    public int myFirstIntegerNumber = 100;
    float myFirstFloatNumber = 1.85f;

    // Text
    public string myFirstString;

    // Logical variable
    bool myFirstBoolean = true;
    // Data structure
    // Scope -- Type -- Values
    // 3.a.Arrays
    public int[] myIntegreArray = { 1, 2, 3, 4, 5, 6 };
    public float[] myFloatArray = new float[5];

    // 3.b.Lists
    public List<int> myIntegerList = new List<int>();
    // 2.Functions
    // Scope -- Type -- Variables -- Body (Intructions)
    // Use this for initialization
    void start()
    {
        Debug.Log("Addition of 5 and 3 is:" + AdditionOfNumbers(5, 3));
        myFloatArray[2] = 3.2f;
        myFloatArray[3] = 5.7f;
        myFloatArray[4] = 9.5f;

        myIntegerList.Add(1);
        myIntegerList.Add(2);
        myIntegerList.Add(3);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hello world!");
    }

    int AdditionOfNumbers(int number1, int number2)
    {
        int additionResult = number1 + number2;
        return additionResult;

    }




}

