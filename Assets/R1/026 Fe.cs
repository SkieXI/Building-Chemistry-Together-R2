using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fe : MonoBehaviour {
        public Fe(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Iron";
    this.publicNumber = 26;
    this.valance = 2;
    this.protons = 26;
    this.neutrons = 30;
    this.electrons = 26;
    this.mass = 55.845;
    this.trivia = "This is Iron.";
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