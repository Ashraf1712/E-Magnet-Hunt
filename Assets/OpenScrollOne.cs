using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScrollOne : MonoBehaviour
{
    [SerializeField] GameObject ScrollPrefabs;

    public void openScroll()
    {
        ScrollPrefabs.SetActive(true);
    }

    public void closeScroll()
    {
        ScrollPrefabs.SetActive(false);
    }
}
