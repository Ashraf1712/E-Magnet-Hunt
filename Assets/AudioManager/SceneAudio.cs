using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAudio : MonoBehaviour
{
    public AudioClip changeAudio;

    void Start()
    {
        AudioManager audioManager = FindObjectOfType<AudioManager>();
        audioManager.ChangeBackgroundMusic(changeAudio);
    }
}