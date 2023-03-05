using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionAndAnswer : MonoBehaviour
{
    [Header("Question And Answer Component")]
    [SerializeField] private string questionName;
    [SerializeField] private string answer;

    [Header("Input Field Component")]
    [SerializeField] private InputField inputField;
    [SerializeField] private Text questionText;

    [Header("Animator")]
    public QuestionButton qb;
    private bool isCorrect = false;

    private void Start()
    {
        questionText.text = questionName;
        inputField.onValueChanged.AddListener(val =>
        {
            if (val.ToUpper().Trim() == answer.ToUpper().Trim())
            {
                isCorrect = true;
            }
            else
            {
                isCorrect = false;
            }
        });
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
