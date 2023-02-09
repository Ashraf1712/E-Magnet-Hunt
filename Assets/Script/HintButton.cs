using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton : MonoBehaviour
{
    [SerializeField] private GameObject hint;
    public void showHint()
    {
        hint.SetActive(true);
    }
    
    public void closeHint()
    {
        hint.SetActive(false);
    }
}
