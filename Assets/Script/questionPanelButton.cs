using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionPanelButton : MonoBehaviour
{
    [SerializeField] private GameObject question;
    public void displayQuestion()
    {
        question.SetActive(true);
    }

    public void hideQuestion()
    {
        question.SetActive(false);
    }
}
