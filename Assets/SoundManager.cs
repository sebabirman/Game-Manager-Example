﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioSource source;

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);

        source = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip clip)
    {
       //source.Stop();
        source.loop = false;
        source.PlayOneShot(clip);
    }
}
