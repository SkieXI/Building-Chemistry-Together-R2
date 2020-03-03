using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//Script used to expand and retract the main menu.
//Turtorial: https://www.youtube.com/watch?v=nH-_ZGodtIQ
public class DropDown : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public RectTransform container;
    public bool IsOpen;

    public void OnPointerEnter(PointerEventData eventData)
    {
        IsOpen = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        IsOpen = false;
    }




    // Start is called before the first frame update
    void Start()
    {
        //Look for the gameobject to apply the scrip to.
        container = transform.Find("MenuContainer").GetComponent<RectTransform>();
        //Toggle to see if the menu is expanded or not.
        IsOpen = false;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = container.localScale;
        //Animation to shift the scale from 100% to 0%.
        // (y value, 1 = fully open, time for animation)
        scale.y = Mathf.Lerp(scale.y, IsOpen ? 1 : 0 , Time.deltaTime * 12);

        container.localScale = scale;
        
    }
}
