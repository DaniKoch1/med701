using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public Sound[] _sounds;
    public AudioSource audioSource;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlaySound(string name)
    {
        Sound s = Array.Find(_sounds, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sound nt found");
        }
        else
        {
            audioSource.clip = s.clip;
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}
