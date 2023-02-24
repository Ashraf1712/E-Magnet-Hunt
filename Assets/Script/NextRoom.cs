using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextRoom : MonoBehaviour
{
    public string toTheNextRoom;
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void ClaimKey()
    {
        ToTheNextScene levelChanger = FindObjectOfType<ToTheNextScene>();
        levelChanger.SceneName= toTheNextRoom;
        levelChanger.onClick();
    }

}
