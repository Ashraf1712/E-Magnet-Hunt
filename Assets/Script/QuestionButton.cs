using UnityEngine;
using UnityEngine.UI;
public class QuestionButton : MonoBehaviour
{
    public GameObject fairiesSwirl;

    [Header("Keys Component")]
    public GameObject keySwirl;
    public BoxCollider2D keyCollider;

    public GameObject enemySprite;
    public Sprite enemyDie;

    public void correctAnswer()
    {
        fairiesSwirl.SetActive(false);
        keySwirl.SetActive(false);
        keyCollider.enabled = true;
        if(enemySprite.GetComponent<Image>() != null)
        {
            enemySprite.GetComponent<Image>().sprite = enemyDie;
        }
        else
        {
            enemySprite.GetComponent<SpriteRenderer>().sprite = enemyDie;
        }
    }

    public void wrongAnswer()
    {
        HealthBar.currentHealth -= 1;
    }
}
