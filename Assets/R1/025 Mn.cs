using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mn : MonoBehaviour {
    public Mn(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Manganese ";
    this.publicNumber = 25;
    this.valance = 7;
    this.protons = 25;
    this.neutrons = 30;
    this.electrons = 25;
    this.mass = 54.93805;
    this.trivia = "This is Manganese .";
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