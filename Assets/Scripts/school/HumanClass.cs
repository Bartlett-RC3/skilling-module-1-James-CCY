// References
// Class Definition
//scope -- type -- Names

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanClass : MonoBehaviour
{
    // variables
    int age;
    float height;
    bool generder;
    string firstNames, familyname;
    float energy;


    // Constructor
    public HumanClass(int _age,float _height, bool _generder, string _firstNames, string _familyname)
    {
        age = _age;
        height = _height;
        generder = _generder;
        firstNames = _firstNames;
        familyname = _familyname;
        energy = 100;       
    }



    // Function (Methods)

    public void DayInlife()
    {
        Ageing();
        Eating();
        Sleeping();
    }
    public string GetfirstNames()
    {
        return firstNames;
    }
    public void Setfirstnames(string newfirstNames)
    {
        firstNames = newfirstNames;

    }
    private void Ageing()
    {
        age = age + 1;
        energy = energy - 1;
    }
    public void Eating()
    {
   
        energy = energy - 1;
    }
    private void Sleeping()
    {
    
        energy = energy + 1;
    }
        
    
}
