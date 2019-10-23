using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F : MonoBehaviour
{
    //All values that are guaranteed to be used.
    public string name;
    public static int publicNumber;
    public double mass;
    public int protons;
    public int neutrons;
    public int valance;
    public int electrons;
    public string trivia;

    //Possible values.
    public string shell; // IE: 2p
    public bool diatomic;
    public bool radioactive;
}