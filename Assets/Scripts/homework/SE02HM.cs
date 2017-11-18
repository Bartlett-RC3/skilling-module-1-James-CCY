using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SE02HM : MonoBehaviour
{
        
    // Use this for initialization
    enum months { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct ,Nov ,Dec };
    
    static void Main()
    {
        int month = (int)months.Dec;

        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
        int randomNumber = rnd.Next(12);
        Debug.Log("month number "+ randomNumber + month);

        }
      
    }

    //
   
    public float  monthnumber = 12;
    public float datenumber =   27 ;
    
    public int Jamesbirthdaymonth = 12;
    public int Jamesbirthdaydate = 27;
    
    //Dogclass

    void Start ()
    {
        Dogclass dc = new Dogclass();
        print("The intelligence ranking of"+" " + dc.dogsnameA + " " + "is" +" "+ dc.IntelligenceRankA);
        print("The intelligence ranking of" + " " + dc.dogsnameB + " " + "is" + " " + dc.IntelligenceRankB);
        print("The intelligence ranking of" + " " + dc.dogsnameC + " " + "is" + " " + dc.IntelligenceRankC);
        print("The intelligence ranking of" + " " + dc.dogsnameD + " " + "is" + " " + dc.IntelligenceRankD);
        print("The intelligence ranking of" + " " + dc.dogsnameE + " " + "is" + " " + dc.IntelligenceRankE);

        print("RANKING percent of "+ dc.dogsnameA+" "+"is" + " " + dc.IntelligenceRankApercent()+"%");
        print("RANKING percent of " + dc.dogsnameB + " " + "is" + " " + dc.IntelligenceRankBpercent() + "%");
        print("RANKING percent of " + dc.dogsnameC + " " + "is" + " " + dc.IntelligenceRankCpercent() + "%");
        print("RANKING percent of " + dc.dogsnameD + " " + "is" + " " + dc.IntelligenceRankDpercent() + "%");
        print("RANKING percent of " + dc.dogsnameE + " " + "is" + " " + dc.IntelligenceRankEpercent() + "%");
    }
	
	// Update is called once per frame
	void Update ()
	{   
	    if (Input.GetKeyDown(KeyCode.Space))
	        Numberguess();

	    monthnumber = Mathf.Round(Time.deltaTime * 10);
        datenumber = Mathf.Round(Time.deltaTime * 100);
     }

    void Numberguess()
    {
        if (monthnumber == Jamesbirthdaymonth && datenumber == Jamesbirthdaydate )
        {
            Debug.Log("James' birthday is 12/27 ");
        }
        else if (monthnumber == Jamesbirthdaymonth || datenumber == Jamesbirthdaydate)
        {
            Debug.Log("Keep guessing u almost there");
        }
        else
        {
            Debug.Log("it's fine u still have lots of chances");
        }
    }

}
