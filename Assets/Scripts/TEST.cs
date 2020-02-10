using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


//This class was created using help from the following websites.
//Drag and drop inventory.
//https://forum.unity.com/threads/here-is-a-drag-and-drop-inventory.98893/

//Create and drag prefabs.
//https://forum.unity.com/threads/spawn-and-drag-prefabs.555409/

//Keeping an object dragged after instanciated.
//https://answers.unity.com/questions/340619/onmousedown-instantiate-a-prefab-and-keep-it-dragg.html

//Youtube Turtorial for Drag and Drop.
//https://www.youtube.com/watch?v=c47QYgsJrWc
public class TEST : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{


    // public GameObject sphere;
    public static GameObject DraggedObject;//This degnitates which object is going to be moved around.
    var AtomCopy = Instantiate<AtomHolder>();
    Vector3 MousePoint; // This stores the coordinates of the mouse at the point when its clicked down.
    Transform NullSpace; //More or less the ENTIRE screen aside from the trays. 

    public void Start()
    {
        
    }
    public void Update()
    {

    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        DraggedObject = this.GetComponent<AtomHolder>().Sphere;
        Debug.Log(DraggedObject.name + " Is being pressed.");
        MousePoint = transform.position;
        
        NullSpace = transform.parent;

        //GetComponent<AtomHolder>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       //DraggedObject = this.GetComponent<AtomHolder>().Sphere;
        Debug.Log(DraggedObject.name + " Is let go.");
        DraggedObject = null;
            transform.position = MousePoint;
    }


    /*
    public void OnPointerDown(PointerEventData eventData)
    {

       Debug.Log(this.atom.name + " Was Clicked.");
    

       // Debug.Log("Button is PRessed.");

            //This is to get the current position of the mouse in its relation to the 3D enviroment around it.
            var CamPos = Input.mousePosition; //Camera.current.ScreenPointToRay(Input.mousePosition);
            var Sphere = this.atom.Sphere; //Points to the prefab attached to the element.
            //public Transform sphere;

            //This is creating a new Vector3 variable that has a X,Y,Z, postion value.
            Vector3 clickPoint = new Vector3(CamPos.x, CamPos.y, 0);

            Instantiate(Sphere, clickPoint, Quaternion.identity);

    //GameObject atom = Instantiate(sphere, clickPoint, Quaternion.identity);// CamPos, Quaternion.identity);
    //  Instantiate(GetComponent., clickPoint, Quaternion.identity);

}
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        // this.GameObject.name = button name. DO NOT USE.
        // this.atom.name = the name variable within the atom object.
        Debug.Log(this.atom.name + " No longer being clicked");
        Destroy(this.atom.Sphere);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log(this.gameObject.name + " I think we're draggin something here....");
       // var Sphere = Instantiate(this.atom.Sphere);
        //var ray = Camera.main.ScreenPointToRay(eventData.position);

        //Sphere.transform.position = Camera.main.transform.position;
        //Instantiate(this.atom.Sphere, eventData.position);
    }
    */
}
