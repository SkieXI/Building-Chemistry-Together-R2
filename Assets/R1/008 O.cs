using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O : MonoBehaviour
{

    public O(string name, int publicNumber, Vector3 valance, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Oxygen";
        this.publicNumber = 8;
        this.protons = 8;
        this.neutrons = 8;
        this.electrons = 8;
        this.mass = 15.999;
        this.trivia = "This is oxygen.";


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