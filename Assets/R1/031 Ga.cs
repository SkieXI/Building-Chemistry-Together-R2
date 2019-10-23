using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ga : MonoBehaviour {
    
    public Ga(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Gallium";
    this.publicNumber = 31;
    this.valance = 3;
    this.protons = 31;
    this.neutrons = 39;
    this.electrons = 31;
    this.mass = 30.974;
    this.trivia = "This is Gallium.";
}

    public void Update()
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