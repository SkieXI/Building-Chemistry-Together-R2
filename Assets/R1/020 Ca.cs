using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ca : MonoBehaviour {
    public Ca(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Calcium";
    this.publicNumber = 20;
    this.valance = 2;
    this.protons = 20;
    this.neutrons = 20;
    this.electrons = 20;
    this.mass = 40.078;
    this.trivia = "This is Calcium.";
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