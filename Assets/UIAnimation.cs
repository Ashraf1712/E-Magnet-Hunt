using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine.UI;

public class UIAnimation : MonoBehaviour
{
    public float duration = 1.0f;
    public RectTransform title;
    public Button[] button;

    private void Start()
    {
        StartCoroutine(Title());
        StartCoroutine(Button());
    }
    IEnumerator Title()
    {
        title.localScale = new Vector3(0f, 0f, 1f);
        title.DOScale(new Vector3(1f, 1f, 1f), duration).SetEase(Ease.OutBounce);
        yield return new WaitForSeconds(duration);
        title.DOScale(new Vector3(1.0f, 1.0f, 1.0f), duration)
            .From(new Vector3(1.1f, 1.1f, 1.1f))
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }

    IEnumerator Button()
    {
        foreach(Button buttons in button)
        {
            buttons.transform.localScale = new Vector3(0f, 0f, 1f);
            buttons.transform.DOScale(new Vector3(0.6f, 0.6f, 1f), duration).SetEase(Ease.OutSine);
        }
        yield return new WaitForSeconds(duration);
    }
}
