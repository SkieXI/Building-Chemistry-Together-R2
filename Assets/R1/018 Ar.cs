using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ar : MonoBehaviour {

    public Ar(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Argon";
        this.publicNumber = 18;
        this.valance = 8;
        this.protons = 18;
        this.neutrons = 22;
        this.electrons = 18;
        this.mass = 39.948;
        this.trivia = "This is argon.";
    }

    public string name { get; set; }
    public int publicNumber { get; set; }
    public double mass { get; set; }
    public int valance { get; set; }
    public Vector3 valancePOS { get; set; }
    public string Name { get; set; }
    public int protons { get; set; }
    public int neutrons { get; set; }
    public int electrons { get; set; }
    public string trivia { get; set; }
}