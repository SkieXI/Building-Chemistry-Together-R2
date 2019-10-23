using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomScript : MonoBehaviour
{
    public GameObject AtomModel;
    public string name;
    public int publicNumber;
    public int valance;
    public double mass;
    public Vector3 valancePOS;
    public int protons;
    public int neutrons;
    public int electrons;
    public int shell;
    public string trivia;
    

    public AtomScript(string name, int publicNumber, int valance, int protons, int neutrons, int electrons, int shell, double mass, string trivia)
    {
        this.name = name;
        this.publicNumber = publicNumber;
        this.valance = valance;
        this.protons = protons;
        this.neutrons = neutrons;
        this.electrons = electrons;
        this.shell = shell;
        this.mass = mass;
        this.trivia = trivia;
    }
}
