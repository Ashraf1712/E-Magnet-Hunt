using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheNextScene : MonoBehaviour
{
    [SerializeField] string SceneName;
    public void onClick()
    {
        SceneManager.LoadScene(SceneName);
    }
    public void Restore()
    {
        HealthBar.currentHealth = 3;
    }
}
