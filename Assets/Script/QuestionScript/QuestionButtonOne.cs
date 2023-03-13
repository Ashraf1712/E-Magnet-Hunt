using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionButtonOne : MonoBehaviour
{
    [Header("Animator")]
    public LastMissionAnimation _last;
    public Animator _codeAnim;
    public BoxCollider2D safeBoxCollider;
    public GameObject swirlImage;
    public HintChanger hitnChange;

    public float question;

    public void correctAnswer()
    {
        //Check Question Number
        if (question > 0)
        {
            HintChanger hint = FindObjectOfType<HintChanger>();
            if (hint != null) hint.changeHint();
            question -= 1;
            _last.nextQuestionTransition();
            if(question == 11 || question == 7 || question == 3)
                _codeAnim.SetTrigger("code");

            if (question == 0)
            {
                _codeAnim.SetTrigger("code");
                swirlImage.GetComponent<Image>().DOFade(0f, 4f).OnComplete(() => {
                    swirlImage.SetActive(false);
                    safeBoxCollider.enabled = true;
                });
            }
        }
    }

    public void wrongAnswer()
    {
        HealthBar.currentHealth -= 1;
    }
}
