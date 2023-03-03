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
                _keysAnim.SetTrigger("KeysDone");
            }
        }
    }

    public void wrongAnswer()
    {
        HealthBar.currentHealth -= 1;
    }
}
