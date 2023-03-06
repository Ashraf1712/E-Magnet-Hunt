using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionAndAnswer : MonoBehaviour
{
    [Header("Answer")]
    [SerializeField] private string[] acceptableAnswer;

    [Header("Input Field Component")]
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button interactableButton;


    [Header("Animator")]
    public QuestionButton qb;
    private bool isCorrect = false;

    private void Start()
    {
        foreach (var answer in acceptableAnswer)
        {
            inputField.onValueChanged.AddListener(val =>
            {
                if (string.IsNullOrEmpty(inputField.text))
                    interactableButton.interactable = false;
                else 
                    interactableButton.interactable = true;
                if (val.ToUpper().Trim() == answer.ToUpper().Trim())
                {
                    isCorrect = true;
                    return;
                }
            });
        }
        isCorrect= false;
    }

    public void correctAnswer() 
    { 
        if(isCorrect)
        {
            qb.correctAnswer();
            this.gameObject.SetActive(false);
        }
        else
        {
            qb.wrongAnswer();
        }
    }

}
