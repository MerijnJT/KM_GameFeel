using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public float increment = 0.1f;
    public float currentValue = 0.5f;
    public float maxValue = 1;
    public bool keyDown;
    public Slider slider;
    public AudioSource audioSource;
    public AudioSource audioSource2;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("volumeSet") == 1)
        {
            currentValue = PlayerPrefs.GetFloat("volume");
        }
        slider.value = currentValue;
        audioSource.volume = currentValue;
        audioSource2.volume = currentValue;
        PlayerPrefs.SetFloat("volume", currentValue);
        PlayerPrefs.SetInt("volumeSet", 1);

    }
    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            if (!keyDown)
            {
                if (Input.GetAxis("Horizontal") > 0)
                {
                    if (currentValue < maxValue)
                    {
                        currentValue += increment;
                    }
                }
                else if (Input.GetAxis("Horizontal") < 0)
                {
                    if (currentValue > 0)
                    {
                        currentValue -= increment;
                    }
                }

                keyDown = true;
                slider.value = currentValue;
                audioSource.volume = currentValue;
                audioSource2.volume = currentValue;
                PlayerPrefs.SetFloat("volume", currentValue);
            }
        }
        else
        {
            keyDown = false;
        }

    }
}
