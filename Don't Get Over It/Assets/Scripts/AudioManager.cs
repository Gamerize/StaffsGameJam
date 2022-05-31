using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Audio[] AudioClip;

    public static AudioManager instance;

    private void Awake()
    {

        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Audio a in AudioClip)
        {
            a.source = gameObject.AddComponent<AudioSource>();
            a.source.clip = a.Sound;
            a.source.volume = a.volume;
            a.source.loop = a.loop;
        }
    }

    private void Start()
    {
        playAudio("Title Theme");
    }

    public void playAudio(string name)
    {
        foreach (Audio a in AudioClip)
        {
            if (a.m_Name == name)
            {
                a.source.Play();
            }
        }
    }

    public void stopAudio(string name)
    {
        foreach (Audio a in AudioClip)
        {
            if (a.m_Name == name)
            {
                a.source.Stop();
            }
        }
    }
}
