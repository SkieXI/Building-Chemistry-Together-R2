using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This class is connected to a lable or text field within the GUI. And this is where that textbox is controlled.

//Example code:
//https://stackoverflow.com/questions/3717028/access-list-from-another-class
public class Readout : MonoBehaviour
{

    public Spawn spawn = new Spawn();

    public void OnMouseDown()
    {
        
    }


    public Text totalE;             //Total number of electrons.
    public Text totalM;             //Total mass of object.
    public Text isBallanced;        //Is the molecule stable?


}
