using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerSlot : MonoBehaviour, IDropHandler
{
    public int answerSlotID;
    public bool correct = false;

    private void Update()
    {
        if(transform.childCount == 0)
        {
            correct = false;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;
            if (draggableItem.answerID == answerSlotID)
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }

    }
}