using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;


public class testing : MonoBehaviour {


    public string text = "happy brthday";
    public bool celebrite = true;
    public float posX = 0.5f;
    public int numnber = 5;
    //arrays
    string [] dogsname = new string []{"Labrador Retriever","German Shepherd","Golden Retriever", "Bulldog", "Beagle" };
    //list
    List<string> months = new List<string>(){"December","Feburary"};
    //Dictionary
    Dictionary<string, string> totalmonths = new Dictionary<string, string>();
   


    //
    void Start()
    {
        //arrays
        print("1. " + dogsname[0] +"2. "+ dogsname[1] + "3. " + dogsname[2]+ "4. " + dogsname[3] + "5. " + dogsname[4]);
        print("The sum of species of dog is " + dogsname.Length);
        //list
        months.Add("March");
        months.Add("April");
        months.Remove("April");
       

        print("the sum of my favorite months is "+ months.Count);
        print("the first one is "+ months[0]+" , "+"the other one is "+months[1]);
        print("Last month "+ months[months.Count-1]);

        //Dictionary
        totalmonths.Add("month.No.12","December");
        totalmonths.Add("month.No.11", "November");

        print("Month No.12  is  "+ totalmonths["month.No.12"]);
        print("Month No.1  is "+ totalmonths.ContainsKey("Month No.1"));

        //conditiontest
        conditiontest();
        //For loop
        Looptest();


        //
        text = Text ("calling people --> ");//"Update during Start() ";
        print("play hard study hard = "+ posX + numnber);
        //
    }


    //
    void conditiontest()
    {
        string name = "James";

        if (name == "Peter")
        {
            print("name is Peter");
        }
        else if (name == "James" )
        {
            print("Name is James");
        }
        else
        {
            print("Name is not Peter");
        }

        int health = 0;
        Boolean isDEAD = health <= 0;
        print("isDead"+isDEAD);

        if (isDEAD)
        {
            print("player is dead");
        }
        string mode = isDEAD == true ? "Gameover" : "IsPlaying";
        print("Game Mode"+mode);
    }
    //

    //For loop
    void Looptest()
    {
        for (int i = 0; i < 10; i++)
        {
          print("loop"+i);  
        }
        for (int i = 9; i > -1; i--)
        {
            print("loop" + i);
        }
        for (int i = 0; i < dogsname.Length; i++)
        {
            print("dogs name "+i+" is "+ dogsname[i]);
        }
        foreach (string name in months)
        {
            print(name);
        }
        foreach (var item in totalmonths)
        {
            print(item.Key+" "+item.Value);
        }
    }


    void Update()
    {
        
    }

    string Text(string value)
    {
       return value + "oh my shit ";
    }



}