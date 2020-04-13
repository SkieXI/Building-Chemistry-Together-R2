using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ItemSlot : MonoBehaviour, IDropHandler
{

    public int electronCount;
    public AtomHolder atom;

    [SerializeField]
    public UnityEvent OnEndDrag;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Dropping into the item slot!");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //electronCount = GetComponents
        }
    }
}
