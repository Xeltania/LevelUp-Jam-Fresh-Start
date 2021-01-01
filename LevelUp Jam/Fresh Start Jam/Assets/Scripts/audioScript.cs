using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class audioScript : MonoBehaviour
{
    public Slider volumeSlider; // Volume slider element in the settings canvas
    public AudioSource audioSource; // The audio source to produce music and sound effects within the game.
    public float fVolume = 1;
    public bool bMuted = false;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onVolumeSlide()
    {
        fVolume = volumeSlider.value;
        audioSource.volume = fVolume;

    }
    public void onMuteButtonPressed()
    {
        audioSource.mute = !audioSource.mute;
    }

}



