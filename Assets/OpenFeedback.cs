using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFeedback : MonoBehaviour
{
    [SerializeField] RectTransform WindowsPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(OpenFeedbacks());
    }

    IEnumerator OpenFeedbacks()
    {
        WindowsPrefabs.localScale = Vector3.zero;
        yield return new WaitForSeconds(0.1f);
        WindowsPrefabs.DOScale(1.5f, 1f).SetEase(Ease.Linear).OnComplete(() =>
        {
            WindowsPrefabs.DOScale(1.6f, 0.1f).SetEase(Ease.Linear).OnComplete(() =>
            {
                WindowsPrefabs.DOScale(1.5f, 0.1f).SetEase(Ease.Linear);
            });
        });
    }
}
