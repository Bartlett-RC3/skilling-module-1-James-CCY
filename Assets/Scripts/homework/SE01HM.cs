using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class SE01HM : MonoBehaviour {

   
    private int Integer = 7;
    private float Float = 2.7f;
    private string String = " The followings numbers are  : ";

    //arrays
    string[] dogsname = new string[] { "Labrador Retriever", "German Shepherd", "Golden Retriever", "Bulldog", "Beagle" };
    //list
    List<string> months = new List<string>() { "December", "Feburary" };
    //Dictionary
    Dictionary<string, string> totalmonths = new Dictionary<string, string>();


    // Use this for initialization
    void Start()
    {
        Debug.Log(String);
        Debug.Log(Float);
        Debug.Log(Integer);

        //arrays

        print("1. " + dogsname[0] + "2. " + dogsname[1] + "3. " + dogsname[2] + "4. " + dogsname[3] + "5. " + dogsname[4]);
        print("The sum of species of dog is " + dogsname.Length);

        //list 
        months.Add("March");
        months.Add("April");
        months.Remove("April");

        print("the sum of my favorite months is " + months.Count);
        print("the first one is " + months[0] + " , " + "the other one is " + months[1]);
        print("Last month " + months[months.Count - 1]);

        //Dictionary
        totalmonths.Add("month.No.12", "December");

        print("Month No.12  is  " + totalmonths["month.No.12"]);
        print("Month No.1  is " + totalmonths.ContainsKey("Month No.1"));



    }

    // Update is called once per frame
    void Update()
    {


    }
}


