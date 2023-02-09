using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheNextScene : MonoBehaviour
{
    public Animator animator;
    public string SceneName;
    public void onClick()
    {
        animator.SetTrigger("FadeOut");
    }
    public void Restore()
    {
        HealthBar.currentHealth = 3;
    }
    public void onFadeComplete()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Quit()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
        Application.Quit();
    }
}
