using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public B(string name, int publicNumber, Vector3 valance, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Boron";
        this.publicNumber = 5;
        this.protons = 5;
        this.neutrons = 6;
        this.electrons = 5;
        this.mass = 10.811;
        this.trivia = "This is boron";


    }

    public string name { get; set; }
    public int publicNumber { get; set; }
    public double mass { get; set; }
    public Vector3 valancePOS { get; set; }
    public string Name { get; set; }
    public int protons { get; set; }
    public int neutrons { get; set; }
    public int electrons { get; set; }
    public string trivia { get; set; }
}