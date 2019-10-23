using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Na : MonoBehaviour {

    public Na(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Sodium";
        this.publicNumber = 11;
        this.valance = 1;
        this.protons = 11;
        this.neutrons = 12;
        this.electrons = 11;
        this.mass = 22.990;
        this.trivia = "This is sodium.";


    }

    public string name;
    public int publicNumber;
    public double mass;
    public int valance;
    public Vector3 valancePOS;
    public string Name;
    public int protons;
    public int neutrons;
    public int electrons;
    public string trivia;
}