using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S : MonoBehaviour {

public S(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
{
    this.name = "Sulfer";
    this.publicNumber = 16;
    this.valance = 6;
    this.protons = 16;
    this.neutrons = 16;
    this.electrons = 16;
    this.mass = 32.066;
    this.trivia = "This is sulfer.";


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