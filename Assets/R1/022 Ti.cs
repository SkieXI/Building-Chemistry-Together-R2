using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ti : MonoBehaviour {
    public Ti(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Titanium";
    this.publicNumber = 22;
    this.valance = 4;
    this.protons = 22;
    this.neutrons = 26;
    this.electrons = 22;
    this.mass = 47.867;
    this.trivia = "This is Titanium.";
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