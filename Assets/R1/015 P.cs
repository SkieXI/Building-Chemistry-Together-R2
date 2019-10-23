using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : MonoBehaviour {

    public P(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Phosphorus";
        this.publicNumber = 15;
        this.valance = 5;
        this.protons = 15;
        this.neutrons = 16;
        this.electrons = 15;
        this.mass = 30.974;
        this.trivia = "This is phosphorus.";
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