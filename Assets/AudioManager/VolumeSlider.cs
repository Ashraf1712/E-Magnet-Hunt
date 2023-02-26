using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    void Start()
    {
        float savedValue = PlayerPrefs.GetFloat("MasterVolume", 0.5f);
        _slider.value = savedValue;
        AudioManager.instance.ChangeMasterVolume(savedValue);

        _slider.onValueChanged.AddListener(val =>
        {
            PlayerPrefs.SetFloat("MasterVolume", val);
            AudioManager.instance.ChangeMasterVolume(val);
        });

        // Set the initial volume level
        if (savedValue != _slider.value)
        {
            _slider.value = savedValue;
            AudioManager.instance.ChangeMasterVolume(savedValue);
        }
    }



}
