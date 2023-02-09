using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThankYouScene : MonoBehaviour
{
    public GameObject thankYou;

    private void Update()
    {
        if (thankYou.GetComponent<AnswerSlot>().correct)
        {
            SceneManager.LoadScene("ThankYouScene");
            HealthBar.currentHealth = 3;
        }
    }
}
