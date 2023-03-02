using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    [SerializeField] private AudioSource audioSource,sfxSource,congratulationSource;
    [SerializeField] private AudioData soundScriptableObject;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            AudioListener.volume = soundScriptableObject.volume;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        sfxSource.clip = clip;
    }

    public void playCurrentSound() { sfxSource.Play(); }
    public void playCongratsSound() { congratulationSource.Play(); }
    public void ChangeMasterVolume(float value)
    {
        soundScriptableObject.volume = value;
        AudioListener.volume = value;
    }
    public void ChangeBackgroundMusic(AudioClip clip)
    {
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.Play();
    }
}

