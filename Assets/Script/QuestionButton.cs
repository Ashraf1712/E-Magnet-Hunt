using UnityEngine;
using UnityEngine.UI;
public class QuestionButton : MonoBehaviour
{
    [Header("Animator")]
    public Animator _playerAnim;
    public Animator _enemyAnim;
    public Animator _fairyAnim;
    public Animator _keysAnim;
    public Animator _nextQuestion;

    public float question;


    public void correctAnswer()
    {
        HintChanger hint = FindObjectOfType<HintChanger>();
        if (hint != null) hint.changeHint();
        _playerAnim.SetTrigger("Attack");
        //Check Question Number
        if(question > 0)
        {
            question -= 1;
            _enemyAnim.SetTrigger("EnemyDie");
            _nextQuestion.SetTrigger("NextQuestion");
            if(question == 0)
            {
                _enemyAnim.SetTrigger("EnemyDie");
                _fairyAnim.SetTrigger("FairiesDone");
                _keysAnim.SetTrigger("openChest");
            }
        }
    }

    public void wrongAnswer()
    {
        HealthBar.currentHealth -= 1;
    }
}
