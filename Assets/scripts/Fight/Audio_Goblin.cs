using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Audio_Goblin : MonoBehaviour
{
    public float volume = 0.1f;
    public static float static_volume = 0.1f;
    public Slider slider_sound;
    public AudioSource AudioSource;

    private void Awake() {
        volume = static_volume;
        slider_sound.value = volume;
    }

    public void Update() {
        static_volume = volume;

        volume = slider_sound.value;
        AudioSource.volume = volume;
    }
}

