using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillEnemy : MonoBehaviour
{
    //TODO: HealthState - 1
    public Slider enemyHealthSlider;
    public float healthValue = 3f;
    private bool flag = false;
    public Animator animator;
    void Start()
    {
        enemyHealthSlider.value = healthValue;
    }
    public void attackEnemy()
    {
        flag = true;
        if (flag)
        {
            healthValue -= 1;
            enemyHealthSlider.value = healthValue;
            flag = false;
        }
    }

}
