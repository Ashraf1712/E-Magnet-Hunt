using UnityEngine;

public class QuizManagerThree : MonoBehaviour
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
            if (!answer[i].gameObject.GetComponent<DraggableItem>().correct && answer[i].GetComponent<DraggableItem>().onSlot)
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
            if (!answer[i].gameObject.GetComponent<DraggableItem>().onSlot)
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