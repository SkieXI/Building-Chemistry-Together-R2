using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Obsolete code
//Tested and functional []
public class CreateAndDrag : MonoBehaviour
{
    // List of all possible variables that will be stored localy or used in this script. 
    private static GameObject atom;                     // Creates a gameobject
    private static GameObject CurrentAtom;              //  Gameobject CurrentAtom
    public string Elum;                                 // Elemunt
    private Material MR;                                // Material to determin the object's color.
    private AtomScript AScript;                         // The script that the variables are going to be pulled from.
    private GameObject DynamicAtom;                     // Gameobject 
    public Button He;                                   // Figuring out which button to pllaysdfsf
    public Button H;
    public Button Li;
    public Text electronDisplay;
    GameObject[] protons;
    GameObject[] electrons;
    public int eCount = -1;
    public int baseElectron = 0;
    public int valanceElectonrs;
    public int shell;
    public int energyLevel = 0;
    public int distBetweenEnergyLevels = 150;
    public GameObject temp;
    public GameObject core;
    public bool isActive;
  
    private void Start()
    {
        //Ascript = GameObject.Find("He").GetComponent<Button>();
        DynamicAtom = GameObject.Find("DynamicAtom");
        CurrentAtom = GameObject.Find("CAtom");
        MR = DynamicAtom.GetComponent<MeshRenderer>().material;

        //Find the button.
        //Each script has to have the atomic symbol. Atomic number DO NOT WORK.

        He = GameObject.Find("He").GetComponent<Button>();
        Li = GameObject.Find("Li").GetComponent<Button>();
        atom = GameObject.Find("Atom");
    }

    public void Update()
    {

        CurrentAtom = GameObject.Find("CAtom");                 // Takes the atom that is currently being created and pulls it from Current Atom.
        DynamicAtom = GameObject.Find("DynamicAtom");           // Dynamic Atom is a object that is created inside of each element's script.
        AScript = DynamicAtom.GetComponent<AtomScript>();       // Pulls the variables from the AtomScript class.
        Elum = AScript.name;                                    // Takes the name variable from the AScript object and assings it.
        valanceElectonrs = AScript.valance;                     // Pulls the number of valance electrons from the AtomScript Class.
        shell = AScript.shell;                                  // Pulls the outter most electron shell from the AtomScript Class.

        temp = DynamicAtom;                                     // Creates new object called temp.
        if (Input.GetMouseButtonDown(0))
        {
            isActive = true;

            core = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            temp = Instantiate(DynamicAtom, Input.mousePosition, Quaternion.identity);
            //temp.transform.position = CurrentAtom.transform.position; // + Vector3.right * 200;
            GameObject.CreatePrimitive(PrimitiveType.Sphere);
            core.transform.position = Input.mousePosition;
            //core.transform.localScale = Vector3(5, 5, 5);
        }
        
        if (Input.GetMouseButton(0))
        {
            core.transform.position = Input.mousePosition;

        }
        
        if (Input.GetMouseButtonUp(0) && CurrentAtom)
        {
            temp = null;
        }

        if (shell == 1)
        {
            if (valanceElectonrs == 1)
            {
                temp.transform.RotateAround(Vector3.zero, Vector3.up, (1/2) * Time.deltaTime);
            }
        }

        /*
        if (AScript.name == "Helium")
            {

            for (int p = 1; p < DynamicAtom.GetComponent<AtomScript>().electrons + 1; p++)
            {
                //  Counts the amount of Electrons and determines how many energy levels/rings are needed
                if (eCount + 1 <= 2 && eCount + 1 <= DynamicAtom.GetComponent<AtomScript>().electrons)//(eCount < 2)
                {
                    energyLevel = energyLevel + 1;
                    eCount++;

                }
                else if (eCount + 1 <= 10 && eCount + 1 <= DynamicAtom.GetComponent<AtomScript>().electrons)
                {
                    baseElectron = 2;
                    energyLevel = energyLevel + 1;
                    eCount++;
                }
                else if (eCount + 1 <= 18 && eCount + 1 <= DynamicAtom.GetComponent<AtomScript>().electrons)
                {
                    baseElectron = 10;
                    energyLevel = energyLevel + 1;
                    eCount++;
                }

            }
                    //  Draws the rings around CAtom
            for (int rings = 1; rings<energyLevel + 1; rings++)
             {
                    //USE UNITY TO DRAW A CIRCLE/ RING AROUND CAtom and increase the distance by distBetweenEnergyLevels
                        //TODO.
             }

            //      Determine how many electrons are left unused to reach the shell and display that number
             remainElectron = eCount - baseElectron;

            //      Using the UI, display the amount of remaining electrons and place it on that final ring
            //electronDisplay.text = remainElectron.ToString(); // MIGHT NEED TO CONVERT THE INT remainElectron to a String for the UI to accept it. Unsure how to do so?     
            MR.color = Color.red;
        }

        else if (AScript.name == "Lithium")
        {

            for (int p = 1; p < DynamicAtom.GetComponent<AtomScript>().electrons + 1; p++)
            {
                //  Counts the amount of Electrons and determines how many energy levels/rings are needed
                if (eCount + 1 <= 2 && eCount + 1 <= DynamicAtom.GetComponent<AtomScript>().electrons)//(eCount < 2)
                {
                    energyLevel = energyLevel + 1;
                    eCount++;
                }
                else if (eCount + 1 <= 10 && eCount + 1 <= DynamicAtom.GetComponent<AtomScript>().electrons)
                {
                    baseElectron = 2;
                    energyLevel = energyLevel + 1;
                    eCount++;

                }
                else if (eCount + 1 <= 18 && eCount + 1 <= DynamicAtom.GetComponent<AtomScript>().electrons)
                {
                    baseElectron = 10;
                    energyLevel = energyLevel + 1;
                    eCount++;
                }
            }

            //  Draws the rings around CAtom
            for (int rings = 1; rings < energyLevel + 1; rings++)
            {
                //USE UNITY TO DRAW A CIRCLE/ RING AROUND CAtom and increase the distance by distBetweenEnergyLevels
                //TODO.
            }

            //      Determine how many electrons are left unused to reach the shell and display that number
            remainElectron = eCount - baseElectron;

            //      Using the UI, display the amount of remaining electrons and place it on that final ring
            //electronDisplay.text = remainElectron.ToString(); // MIGHT NEED TO CONVERT THE INT remainElectron to a String for the UI to accept it. Unsure how to do so?     
            MR.color = Color.blue;
        }

            
        
        // ELEMENT BREAK POINT:
        else if (AScript.name == "Be")
        {

            for (int p = 1; p < AScript.electrons + 1; p++)
            {
                //  Counts the amount of Electrons and determines how many energy levels/rings are needed
                if (eCount < 2)//(eCount < 2)
                {
                    energyLevel = energyLevel + 1;
                    baseElectron = 2;
                }
                else if (eCount < 10)
                {
                    energyLevel = energyLevel + 1;
                    baseElectron = 10;
                }
                else if (eCount < 18)
                {
                    energyLevel = energyLevel + 1;
                    baseElectron = 18;
                }
                else
                {
                    energyLevel = energyLevel + 1;
                }
                eCount++;

                //  Draws the rings around CAtom
                for (int rings = 1; rings < energyLevel + 1; rings++)
                {
                    // TODO: USE UNITY TO DRAW A CIRCLE/ RING AROUND CAtom and increase the distance by distBetweenEnergyLevels
                   
                }

                //      Determine how many electrons are left unused to reach the shell and display that number
                remainElectron = eCount - baseElectron;

                //      Using the UI, display the amount of remaining electrons and place it on that final ring
                //electronDisplay.text = remainElectron.ToString(); // MIGHT NEED TO CONVERT THE INT remainElectron to a String for the UI to accept it. Unsure how to do so?     
            }
            MR.color = Color.green;
        }
        */
    }
}