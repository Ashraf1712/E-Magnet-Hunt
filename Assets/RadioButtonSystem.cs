using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public enum Answer
{
    A,
    B,
    C,
    D,
};
public class RadioButtonSystem : MonoBehaviour
{
    [Header("Answer Component")]
    public Answer selectedAnswer;
    public QuestionButton qb;
    private ToggleGroup toggleGroup;


    private void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Submit()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        Debug.Log(toggle.GetComponentInChildren<TextMeshProUGUI>().text.ToString()[0]);
        if(toggle.GetComponentInChildren<TextMeshProUGUI>().text.ToString()[0] == selectedAnswer.ToString()[0]) {
            qb.correctAnswer();
        }
        else
        {
            qb.wrongAnswer();
        }
    }
}
