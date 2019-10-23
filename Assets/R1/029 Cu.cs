using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cu : MonoBehaviour {

    public Cu(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Copper";
    this.publicNumber = 29;
    this.valance = 2;
    this.protons = 29;
    this.neutrons = 35;
    this.electrons = 29;
    this.mass = 63.546;
    this.trivia = "This is Copper.";
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
