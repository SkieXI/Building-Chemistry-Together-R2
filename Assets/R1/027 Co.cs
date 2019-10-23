using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Co : MonoBehaviour {
    public Co(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Cobalt";
    this.publicNumber = 27;
    this.valance = 2;
    this.protons = 27;
    this.neutrons = 32;
    this.electrons = 27;
    this.mass = 58.933195;
    this.trivia = "This is Cobalt.";
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