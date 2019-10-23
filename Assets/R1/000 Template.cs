using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Template : MonoBehaviour
{
    //ALL values that are guaranteed to be used.
    public string name;                                 //The name of the element.
    public static int publicNumber;                     //The Atomic number of the element.
    public double mass;                                 //The Atomic Mass of the element.
    public int protons;                                 //The number of protons within an element by default.
    public int neutrons;                                //The number of neutrons within an element by default.
    public int valance;                                 //The number of electrons within the outtermost electron shell.
    public int electrons;                               //The total number of electrons within an element.
    public string trivia;                               //Random tibit. 

    //Possible values.
    public string shell; // IE: 2p                      //The electron shell configuration I.E. 2p, 
    public bool diatomic;                               //Is the element diatomic?
                                                        // - If yes, then the element cannot be stable by itself.
    public bool radioactive;                            //Is the element radioactive?
                                                        // - If yes. Then EEEHHH???
}