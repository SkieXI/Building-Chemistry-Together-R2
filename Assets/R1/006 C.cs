using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour
{
    public C(string name, int publicNumber, Vector3 valance, int protons, int neutrons, int electrons, double mass, string trivia)
    {
        this.name = "Carbon";
        this.publicNumber = 6;
        this.protons = 6;
        this.neutrons = 6;
        this.electrons = 6;
        this.mass = 12.011;
        this.trivia = "This is carbon.";


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