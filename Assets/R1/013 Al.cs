using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Al : MonoBehaviour
{
    public Al(string name, int publicNumber, int vElectrons, Vector3 valance, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Aluminum";
        this.publicNumber = 13;
        this.vElectrons = 2;
        this.protons = 13;
        this.neutrons = 14;
        this.electrons = 13;
        this.mass = 26.982;
        this.trivia = "This is Aluminum.";


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