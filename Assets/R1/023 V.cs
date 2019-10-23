using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V : MonoBehaviour {
    public V(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Vandium";
    this.publicNumber = 23;
    this.valance = 5;
    this.protons = 23;
    this.neutrons = 28;
    this.electrons = 23;
    this.mass = 50.9415;
    this.trivia = "This is Vanadium.";
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