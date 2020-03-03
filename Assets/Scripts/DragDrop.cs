using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;
    private CanvasGroup CG;

    float Distacnce = 10;
    private RectTransform Rect;

    private void Awake()
    {
        Rect = GetComponent<RectTransform>();
        CG = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        CG.blocksRaycasts = false;
        Debug.Log("WHEEEEEEEE!!!!!!!!!!!!!!!!!!!");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Rect.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("On Drag End.");
        CG.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("This is being held down.");
    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
