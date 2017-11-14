using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogclass : MonoBehaviour {


    // variables
    int popularityRank ;
    int intelligenceRank ;
    string Temperament1 ;
    string Temperament2 ;
    string Temperament3 ;
    string Temperament4 ;
    string origin ;

    // Constructor
    public Dogclass (int _popularityRank , int _intelligenceRank , string _Temperament1, 
                     string _Temperament2, string _Temperament3, string _Temperament4, string _origin)
    {
        popularityRank = _popularityRank;
        intelligenceRank = _intelligenceRank;
        Temperament1 = _Temperament1;
        Temperament2 = _Temperament2;
        Temperament3 = _Temperament3;
        Temperament4 = _Temperament4;
        origin = _origin;
    }

    // Function (Methods)

    public float popularityRankingpercent()
    {
        return 5/(float)popularityRank  ;
    }

    public string Getorigin()
    {
        return origin;
    }
    public string GetTemperament1()
    {
        return Temperament1;
    }
    public string GetTemperament2()
    {
        return Temperament2;
    }
    public string GetTemperament3()
    {
        return Temperament3;
    }
    public string GetTemperament4()
    {
        return Temperament4;
    }
}
