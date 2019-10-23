using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc : MonoBehaviour {
    public Sc(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Scandium";
    this.publicNumber = 21;
    this.valance = 3;
    this.protons = 21;
    this.neutrons = 24;
    this.electrons = 21;
    this.mass = 44.95591;
    this.trivia = "Scandium.";
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