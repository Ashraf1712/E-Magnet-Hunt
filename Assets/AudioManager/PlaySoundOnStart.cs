using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnStart : MonoBehaviour
{
    public void playSound()
    {
        if (AudioManager.instance == null) return;
        AudioManager.instance.playCurrentSound();
    }
}
