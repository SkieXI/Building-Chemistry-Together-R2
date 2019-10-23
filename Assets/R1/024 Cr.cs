using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cr : MonoBehaviour {
    public Cr(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Chromium";
    this.publicNumber = 24;
    this.valance = 6;
    this.protons = 24;
    this.neutrons = 28;
    this.electrons = 24;
    this.mass = 51.9961;
    this.trivia = "This is Chromium.";
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