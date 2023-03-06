using UnityEngine.EventSystems;
using UnityEngine;

public class AnswerSlotOne : MonoBehaviour, IDropHandler
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
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().transform.localPosition;
            eventData.pointerDrag.transform.SetParent(transform, true);
        }
    }

}