using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    public GameObject[] answer;
    public QuestionButton qb;
    public GameObject questionCanvas;
    [HideInInspector] public bool allCorrect = true;

    private void Update()
    {
        allCorrect = true;
        for (int i = 0; i < answer.Length; i++)
        {
            if (!answer[i].gameObject.GetComponent<AnswerSlot>().correct)
            {
                allCorrect = false;
                break;
            }
        }
    }

    public void CheckAnswer()
    {
        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i].gameObject.GetComponent<Transform>().childCount == 0)
            {
                return;
            }
        }
        if (allCorrect)
        {
            qb.correctAnswer();
            questionCanvas.SetActive(false);
        }
        else
        {
            qb.wrongAnswer();
        }
    }

}
