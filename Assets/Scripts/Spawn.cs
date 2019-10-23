using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    //This is to assign a variable to the script instead of making it a fixed or static variable here.
    //This also allows the script to be used many times over again.
    public AtomHolder atom;

    public List<GameObject> Total = new List<GameObject>();

    //Factory patern.
    // Start is called before the first frame update
    public List<T> getList(List<T>)
    {
        return List<T>;
    }

    void addAtom(int intToAdd)
    {
        //Collecting the information from the atom model class.

        GameObject atomObject = new GameObject();
        

        //Website Example:
        //https://stackoverflow.com/questions/35835221/creating-a-list-of-unity-objects
        


        //Putting these elements into the list.
        atom.AddComponent<mass>;
    }

    void onMouseDown()
    {
        //Messages saying that the button is pressed.
        Debug.Log("Button is PRessed.");
        if (Input.GetMouseButtonDown(0))
        {

            //This is to get the current position of the mouse in its relation to the 3D enviroment around it.
            var CamPos = Input.mousePosition; //Camera.current.ScreenPointToRay(Input.mousePosition);

            

            //This is creating a new Vector3 variable that has a X,Y,Z, postion value.
            Vector3 clickPoint = new Vector3(CamPos.x, CamPos.y, 0);


            Instantiate(atom, clickPoint, Quaternion.identity);
        }
    }

    //When the mouse key is lifted up, another message will be displayed.
    private void OnMouseUp()
    {
        //Message to be displayed.
        Debug.Log("Mouse is letgo.");

        if ()
        {
            Destroy(atom);
        }
    }

}
