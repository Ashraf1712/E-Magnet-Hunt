using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private AudioData audioData;

    void Start()
    {
        _slider.value = audioData.volume;
        _slider.onValueChanged.AddListener(val =>
        {
            AudioManager.instance.ChangeMasterVolume(val);
        });

    }



}
