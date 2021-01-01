using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class audioScript : MonoBehaviour
{
    public Slider volumeSlider; // Volume slider element in the settings canvas
    public AudioSource audioSource; // The audio source to produce music and sound effects within the game.
    public float fVolume;
    public bool bMuted = false;

    //Audio
    public AudioClip testclip;

    // Start is called before the first frame update
    void Start()
    {
        fVolume = 1;
        volumeSlider.value = fVolume;
        audioSource.volume = fVolume;
        DontDestroyOnLoad(gameObject); // Keep the audiosource
        audioSource.clip = testclip;
        audioSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onVolumeSlide()
    {
        fVolume = volumeSlider.value;
        audioSource.volume = fVolume;
        Debug.Log("Volume : " + fVolume);
    }
    public void onMuteButtonPressed()
    {
        bMuted = !audioSource.mute;
        audioSource.mute = bMuted;
        Debug.Log("Mute : " + bMuted);
    }

}



