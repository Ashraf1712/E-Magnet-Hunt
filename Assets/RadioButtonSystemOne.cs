using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RadioButtonSystemOne : MonoBehaviour
{
    [Header("Answer Component")]
    public Answer selectedAnswer;
    public QuestionButtonOne qb;
    private ToggleGroup toggleGroup;


    private void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Submit()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        if (toggle.GetComponentInChildren<TextMeshProUGUI>().text.ToString()[0] == selectedAnswer.ToString()[0])
        {
            qb.correctAnswer();
        }
        else
        {
            qb.wrongAnswer();
        }
    }
}
