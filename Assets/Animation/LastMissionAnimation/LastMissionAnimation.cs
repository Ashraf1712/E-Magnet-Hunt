using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using DG.Tweening;

public class LastMissionAnimation : MonoBehaviour
{
    [SerializeField] RectTransform[] questions;
    [SerializeField] float transitionTime;
    [SerializeField] Ease transitionType;
    private Vector3 originalScale;
    private int count = 0;

    private void Start()
    {
        originalScale = questions[0].localScale;
        StartCoroutine(questionTransition(0));
        questions[0].gameObject.SetActive(true);
    }
    public void nextQuestionTransition()
    {
        count++;
        for (int i = 0; i < questions.Length; i++)
        {
            if (i == count)
            {
                originalScale = questions[i].localScale;
                questions[i].gameObject.SetActive(true);
                StartCoroutine(questionTransition(i));
            }
            else
            {
                questions[i].gameObject.SetActive(false);
            }
        }
    }

    IEnumerator questionTransition(int _count)
    {
        questions[_count].transform.DOScale(0, 0f);
        yield return new WaitForSeconds(0.1f);
        questions[_count].transform.DOScale(originalScale, transitionTime).SetEase(transitionType);
    }
}
