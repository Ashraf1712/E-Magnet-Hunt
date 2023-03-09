using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionMAOne : MonoBehaviour
{
    [Header("Answer Component")]
    public Toggle[] answerToggles;
    public string[] correctAnswers;

    [Header("Animator")]
    public QuestionButtonOne qb;
    private bool[] selectedAnswers;

    void Start()
    {
        selectedAnswers = new bool[answerToggles.Length];
    }

    public void CheckAnswers()
    {
        bool allCorrect = true;

        for (int i = 0; i < answerToggles.Length; i++)
        {
            selectedAnswers[i] = answerToggles[i].isOn;

            // Get the selected answer
            string selectedAnswer = answerToggles[i].GetComponentInChildren<TextMeshProUGUI>().text.ToUpper().Trim();

            // Check if the selected answer is correct
            bool isCorrect = false;
            foreach (string correctAnswer in correctAnswers)
            {
                if (selectedAnswer == correctAnswer.ToUpper().Trim())
                {
                    isCorrect = true;
                    break;
                }
            }

            if (selectedAnswers[i] != isCorrect)
            {
                allCorrect = false;
            }
        }


        if (allCorrect)
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

