using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N : MonoBehaviour
{
    
    public N(string name, int publicNumber, Vector3 valance, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Nitrogen";
        this.publicNumber = 7;
        this.protons = 7;
        this.neutrons = 7;
        this.electrons = 7;
        this.mass = 14.007;
        this.trivia = "This is nitrogen.";


    }

    public string name { get; set; }
    public int publicNumber { get; set; }
    public double mass { get; set; }
    public Vector3 valancePOS { get; set; }
    public string Name { get; set; }
    public int protons { get; set; }
    public int neutrons { get; set; }
    public int electrons { get; set; }
    public string trivia { get; set; }
}