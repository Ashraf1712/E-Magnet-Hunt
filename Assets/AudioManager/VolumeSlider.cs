using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    private static float volumeSlider = 0.5f;
    private void Awake()
    {
        _slider.value = volumeSlider;
    }
    void Start()
    {
        AudioManager.instance.ChangeMasterVolume(_slider.value);
        _slider.onValueChanged.AddListener(val =>
        {
            volumeSlider = val;
            AudioManager.instance.ChangeMasterVolume(val);
        }
        ); 
    }


}
