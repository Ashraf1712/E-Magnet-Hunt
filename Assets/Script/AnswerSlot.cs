using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerSlot : MonoBehaviour, IDropHandler
{
    public int answerSlotID;
    public bool correct = false;

    private void Update()
    {
        if (transform.childCount == 0)
        {
            correct = false;
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.transform.SetParent(transform, true);
        }
    }

}