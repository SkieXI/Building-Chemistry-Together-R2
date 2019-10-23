using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mg : MonoBehaviour {

    public Mg(string name, int publicNumber, int group, Vector3 valance, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Magnesium";
        this.publicNumber = 12;
        this.group = 2;
        this.protons = 12;
        this.neutrons = 12;
        this.electrons = 12;
        this.mass = 24.305;
        this.trivia = "This is Magnesium.";


    }

    public string name { get; set; }
    public int publicNumber { get; set; }
    public int group { get; set; }
    public double mass { get; set; }
    public Vector3 valancePOS { get; set; }
    public string Name { get; set; }
    public int protons { get; set; }
    public int neutrons { get; set; }
    public int electrons { get; set; }
    public string trivia { get; set; }
}