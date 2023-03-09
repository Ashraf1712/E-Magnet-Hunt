using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    public int answerID;
    public Transform backPoint;
    [SerializeField] private Canvas canvas;
    [SerializeField] private GameObject currentGameObject;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public bool onSlot = false;
    public bool correct = false;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        transform.SetParent(currentGameObject.transform);
        transform.SetAsLastSibling();
        onSlot = false;
        correct = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if (!eventData.pointerEnter.CompareTag("AnswerSlot"))
        {
            transform.position = backPoint.position;
        }
        else {
            AnswerSlot answer = eventData.pointerEnter.GetComponent<AnswerSlot>();
            onSlot = true;
            if (answerID == answer.answerSlotID && onSlot)
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        
    }
}
