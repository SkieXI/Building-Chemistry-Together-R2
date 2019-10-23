using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ne : MonoBehaviour
{
    public Ne(string name, int publicNumber, int valance, Vector3 valancePOS, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Neon";
        this.publicNumber = 10;
        this.valance = 8;
        this.protons = 10;
        this.neutrons = 10;
        this.electrons = 10;
        this.mass = 20.1797;
        this.trivia = "This is boron";
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