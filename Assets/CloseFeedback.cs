using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseFeedback : MonoBehaviour
{
    [SerializeField] RectTransform WindowPrefabs;
    [SerializeField] RectTransform CongratulationPrefabs;
    public void closeFeedback()
    {
        WindowPrefabs.DOScale(0f, 1f).SetEase(Ease.OutQuint).OnComplete(() =>
        {
            CongratulationPrefabs.gameObject.SetActive(false);
        });
    }
}
