using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

/* Class used to move a object around.
 * Joe Leon 
 * 3/3/2020
 * 
 * Based on turtorial:
 * Moving 2D objects and having them snap to a point: https://www.youtube.com/watch?v=BGr-7GZJNXg
 * Moving 3D Objects: https://www.youtube.com/watch?v=vn8hnR0RplE
 */
public class DragDrop : MonoBehaviour // IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    float Distacnce = 10;
    private RectTransform Rect;

    float Zpos;
    Vector3 Offset;
    public Camera mainCamera;
    bool drag = false;

    [Space]
    [SerializeField]
    public UnityEvent OnBeginDrag;

    [SerializeField]
    public UnityEvent OnEndDrag;

    void Start()
    {
        Debug.Log("App Start.");
       // mainCamera = Camera.main;
        Zpos = mainCamera.WorldToScreenPoint(transform.position).z;
    }

    void Update()
    {
        if (drag)
        {
            Debug.Log("Moving Stuff.");
            Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Zpos);
            transform.position = mainCamera.ScreenToWorldPoint(pos + new Vector3(Offset.x, Offset.y));
        }
    }

    void OnMouseDown()
    {
        Debug.Log("Clicking on stuff.");
        if (!drag)
        {
            BeginDrag();
        }
    }

    void OnMouseUp()
    {
        Debug.Log("Not clicking on stuff.");
        EndDrag();
    }

    public void BeginDrag()
    {
        OnBeginDrag.Invoke();
        drag = true;
        Offset = mainCamera.WorldToScreenPoint(transform.position) - Input.mousePosition;
    }

    public void EndDrag()
    {
        Debug.Log("Just before not clicking on stuff.");
        OnEndDrag.Invoke();
        drag = false;
        Destroy(this.gameObject);
    }


    /*
    private void Awake()
    {
        Rect = GetComponent<RectTransform>();
        CG = GetComponent<CanvasGroup>();
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        CG.blocksRaycasts = false;

        drag = true;
        Offset = mainCamera.WorldToScreenPoint(transform.position) - Input.mousePosition;
        Rect.anchoredPosition += eventData.delta / canvas.scaleFactor;
        Debug.Log("WHEEEEEEEE!!!!!!!!!!!!!!!!!!!");
    }

    /* Method used for 
     * 
     *
    public void OnDrag(PointerEventData eventData)
    {
        if (drag)
        {
            OnBeginDrag();
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("On Drag End.");
        drag = false;
        CG.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (drag)
        {

        }
        Debug.Log("This is being held down.");
    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    */
}
