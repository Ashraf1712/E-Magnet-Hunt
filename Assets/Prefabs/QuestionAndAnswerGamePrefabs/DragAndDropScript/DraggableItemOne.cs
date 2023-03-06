using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItemOne : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    public int answerID;
    public Transform backPoint;
    [SerializeField] private Canvas canvas;
    [SerializeField] private GameObject currentGameObject;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

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
            AnswerSlotOne answer = eventData.pointerEnter.GetComponent<AnswerSlotOne>();
            if (answerID == answer.answerSlotID)
            {
                answer.correct = true;
            }
            else
            {
                answer.correct = false;
            }
        }
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        
    }
}
