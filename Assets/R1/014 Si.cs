using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Si : MonoBehaviour {

    public Si(string name, int publicNumber, int vElectrons, Vector3 valance, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Silicon";
        this.publicNumber = 12;
        this.vElectrons = 4;
        this.protons = 14;
        this.neutrons = 14;
        this.electrons = 14;
        this.mass = 28.086;
        this.trivia = "This is silicon.";


    }

    public string name { get; set; }
    public int publicNumber { get; set; }
    public int vElectrons { get; set; }
    public double mass { get; set; }
    public Vector3 valancePOS { get; set; }
    public string Name { get; set; }
    public int protons { get; set; }
    public int neutrons { get; set; }
    public int electrons { get; set; }
    public string trivia { get; set; }
}