using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This code needs to be at the top of every class so that it can be created by right clicking on hte 
[CreateAssetMenu(fileName = "NewElement", menuName = "New element")]
public class AtomHolder : ScriptableObject
{
    //All values that are guaranteed to be used.

    //Name of the element
    public new string name;
    //The type of prefab
    public GameObject Sphere;
    //The Atomic Number
    public int number;
    //Atomic Mass
    public double mass;
    //Number of Protrons
    public int protons;
    //Number of Neurtrons
    public int neutrons;
    //The number of valance electrons
    public int valance;
    //Total Number of electrons
    public int electrons;
    //Random fact of the day.
    public string trivia;

    //Possible values.
    public string shell; // IE: 2p

    //If the atom is diatomic
    // - Diatomic means that the atom cannot exist by itself, it needs two of itself to remain stable.
    public bool diatomic;
    //Is the atom radioactive.
    // - In the grand scheme of things, this doensn't mean anything here, but it might be good for future proofing.
    public bool radioactive;
}
