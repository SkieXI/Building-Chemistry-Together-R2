using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomModel : MonoBehaviour
{
    //All values that are guaranteed to be used.
    [SerializeField]
    public string name;
    [SerializeField]
    public int number;
    [SerializeField]
    public double mass;
    [SerializeField]
    public int protons;
    [SerializeField]
    public int neutrons;
    [SerializeField]
    public int valance;
    [SerializeField]
    public int electrons;
    [SerializeField]
    public string trivia;

    //Possible values.
    [SerializeField]
    public string shell; // IE: 2p
    [SerializeField]
    public bool diatomic;
    [SerializeField]
    public bool radioactive;
}
