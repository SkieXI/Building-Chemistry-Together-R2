using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ni : MonoBehaviour {
        public Ni(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Nickel";
    this.publicNumber = 28;
    this.valance = 10;
    this.protons = 28;
    this.neutrons = 31;
    this.electrons = 28;
    this.mass = 58.634;
    this.trivia = "This is Nickel.";
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