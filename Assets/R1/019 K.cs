using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class K : MonoBehaviour {
    public K(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Potassium";
    this.publicNumber = 19;
    this.valance = 1;
    this.protons = 19;
    this.neutrons = 20;
    this.electrons = 19;
    this.mass = 39.0983;
    this.trivia = "This is Potassium.";
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