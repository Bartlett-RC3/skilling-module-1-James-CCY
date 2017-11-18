

using System.Collections.Generic;

public class Dogclass  {


    // variables

    public string dogsnameA = "Labrador Retriever";
    public int IntelligenceRankA = 7;

    public string dogsnameB = "German Shepherd";
    public int IntelligenceRankB = 3;

    public string dogsnameC = "Golden Retriever";
    public int IntelligenceRankC = 4;

    public string dogsnameD = "Bulldog";
    public int IntelligenceRankD = 77;

    public string dogsnameE = "Beagle";
    public int IntelligenceRankE = 72;

    public float IntelligenceRankApercent()
    {
        return (100-(IntelligenceRankA/((float)IntelligenceRankA+ (float)IntelligenceRankB + (float)IntelligenceRankC + (float)IntelligenceRankD + (float)IntelligenceRankE)*100));
    }

    public float IntelligenceRankBpercent()
    {
        return (100 - (IntelligenceRankB / ((float)IntelligenceRankA + (float)IntelligenceRankB + (float)IntelligenceRankC + (float)IntelligenceRankD + (float)IntelligenceRankE) * 100));
    }
    public float IntelligenceRankCpercent()
    {
        return (100 - (IntelligenceRankC / ((float)IntelligenceRankA + (float)IntelligenceRankB + (float)IntelligenceRankC + (float)IntelligenceRankD + (float)IntelligenceRankE) * 100));
    }
    public float IntelligenceRankDpercent()
    {
        return (100 - (IntelligenceRankD / ((float)IntelligenceRankA + (float)IntelligenceRankB + (float)IntelligenceRankC + (float)IntelligenceRankD + (float)IntelligenceRankE) * 100));
    }
    public float IntelligenceRankEpercent()
    {
        return (100 - (IntelligenceRankE / ((float)IntelligenceRankA + (float)IntelligenceRankB + (float)IntelligenceRankC + (float)IntelligenceRankD + (float)IntelligenceRankE) * 100));
    }


    // previous
    /*
   public Dogclass(int _popularityRank , int _intelligenceRank , string _Temperament1, 
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
    */

    void Start()
    {
        
    }
}
