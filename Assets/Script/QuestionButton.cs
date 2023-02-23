using UnityEngine;
using UnityEngine.UI;
public class QuestionButton : MonoBehaviour
{
    [Header("Animator")]
    public Animator _playerAnim;
    public Animator _enemyAnim;
    public Animator _fairyAnim;
    public Animator _keysAnim;

    public void correctAnswer()
    {
        _playerAnim.SetTrigger("Attack");
        _enemyAnim.SetTrigger("EnemyDie");
        _fairyAnim.SetTrigger("FairiesDone");
        _keysAnim.SetTrigger("KeysDone");
    }

    public void wrongAnswer()
    {
        HealthBar.currentHealth -= 1;
    }
}
