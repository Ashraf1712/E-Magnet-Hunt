using UnityEngine;

public class QuizManagerTwo : MonoBehaviour
{
    public GameObject[] answer;
    public QuestionButtonOne qb;
    public GameObject questionCanvas;
    [HideInInspector] public bool allCorrect = true;

    private void Update()
    {
        allCorrect = true;
        for (int i = 0; i < answer.Length; i++)
        {
            if (!answer[i].gameObject.GetComponent<AnswerSlotOne>().correct)
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