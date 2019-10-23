using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class H : MonoBehaviour
{
    //All values that are guaranteed to be used.
    public string name = "Hydrogen";
    public static int publicNumber = 1;
    public double mass = 1.01;
    public int protons;
    public int neutrons;
    public int valance;
    public int electrons;
    public string trivia = "This is Hydrogen.";

    //Possible values.
    public string shell; // IE: 2p
    public bool diatomic = false;
    public bool radioactive = false;
}