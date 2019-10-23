using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Li : MonoBehaviour
{
    
    public string name;
    public int publicNumber;
    public double mass;
    public int valance;
    public string Name;
    public int protons;
    public int neutrons;
    public int electrons;
    public string trivia;

    //Declare the AScript object.
    AtomScript AScript;

    GameObject DynaAtom;

    public void Start()
    {
        //Finding the DynamicAtom object
        //It does not like it when you try to find a Unity object outside of a function.
        AScript = GameObject.Find("DynamicAtom").GetComponent<AtomScript>();

        DynaAtom = GameObject.Find("DynamicAtom");

        name = "Lithium";
        publicNumber = 3;
        protons = 3;
        valance = 4;
        neutrons = 3;
        electrons = 3;
        mass = 6.941;
        trivia = "This is Lithium";

    }


    public void setData()
    {
        AScript.name = name;
        AScript.publicNumber = publicNumber;
        AScript.valance = valance;
        AScript.protons = protons;
        AScript.neutrons = neutrons;
        AScript.electrons = electrons;
        AScript.mass = mass;
        AScript.trivia = trivia;
    }

    public void tempSetData()
    {
        DynaAtom.GetComponent<AtomScript>().name = name;
        DynaAtom.GetComponent<AtomScript>().publicNumber = publicNumber;
        DynaAtom.GetComponent<AtomScript>().valance = valance;
        DynaAtom.GetComponent<AtomScript>().protons = protons;
        DynaAtom.GetComponent<AtomScript>().neutrons = neutrons;
        DynaAtom.GetComponent<AtomScript>().electrons = electrons;
        DynaAtom.GetComponent<AtomScript>().mass = mass;
        DynaAtom.GetComponent<AtomScript>().trivia = trivia;
    }
}