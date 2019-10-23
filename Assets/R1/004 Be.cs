using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Be : MonoBehaviour
{
    public Be(string name, int publicNumber, Vector3 valance, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Beryllium";
        this.publicNumber = 4;
        this.protons = 4;
        this.neutrons = 5;
        this.electrons = 4;
        this.mass = 9.012;
        this.trivia = "This is beryllium.";


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