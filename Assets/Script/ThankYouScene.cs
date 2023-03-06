using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThankYouScene : MonoBehaviour
{
    public GameObject thankYou;
    public ToTheNextScene clickScene;

    private void Update()
    {
        if (thankYou.GetComponent<AnswerSlotOne>().correct)
        {
            clickScene.onClick();
            clickScene.SceneName = "ThankYouScene";
            HealthBar.currentHealth = 3;
        }
    }
}
