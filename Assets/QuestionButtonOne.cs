using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButtonOne : MonoBehaviour
{
    [Header("Animator")]
    public Animator _nextQuestion;
    public Animator _codeAnim;
    public BoxCollider2D safeBoxCollider;

    public float question;


    public void correctAnswer()
    {
        //Check Question Number
        if (question > 0)
        {
            question -= 1;
            _nextQuestion.SetTrigger("NextQuestion");
            _codeAnim.SetTrigger("code");
            if (question == 0)
            {
                safeBoxCollider.enabled = true;
            }
        }
    }

    public void wrongAnswer()
    {
        HealthBar.currentHealth -= 1;
    }
}
