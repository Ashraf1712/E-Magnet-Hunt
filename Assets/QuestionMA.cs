using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionMA : MonoBehaviour
{
    [Header("Question Component")]
    public string question;
    public Text questionText;

    [Header("Answer Component")]
    public Toggle[] answerToggles;
    public string[] correctAnswers;

    private bool[] selectedAnswers;

    void Start()
    {
        questionText.text = question;
        selectedAnswers = new bool[answerToggles.Length];
    }

    public void CheckAnswers()
    {
        bool allCorrect = true;

        for (int i = 0; i < answerToggles.Length; i++)
        {
            selectedAnswers[i] = answerToggles[i].isOn;
            bool isCorrect = Array.IndexOf(correctAnswers, answerToggles[i].GetComponentInChildren<Text>().text) != -1;

            if (selectedAnswers[i] != isCorrect)
            {
                allCorrect = false;
            }
        }

        if (allCorrect)
        {
            Debug.Log("Congratulations! You answered correctly.");
        }
        else
        {
            Debug.Log("Sorry, your answer is incorrect.");
        }
    }
}

