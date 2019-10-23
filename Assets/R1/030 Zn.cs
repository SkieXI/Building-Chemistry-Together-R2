using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zn : MonoBehaviour {
    
    public Zn(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Phosphorus";
        this.publicNumber = 30;
    this.valance = 2;
    this.protons = 30;
    this.neutrons = 35;
    this.electrons = 30;
    this.mass = 65.39;
    this.trivia = "This is Zinc.";
}

public void update()
{
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
