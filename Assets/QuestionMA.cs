using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    [Header("Animator")]
    public QuestionButton qb;
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

            // Get the selected answer
            string selectedAnswer = answerToggles[i].GetComponentInChildren<TextMeshProUGUI>().text.ToUpper();

            // Check if the selected answer is correct
            bool isCorrect = false;
            foreach (string correctAnswer in correctAnswers)
            {
                if (selectedAnswer == correctAnswer.ToUpper())
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

