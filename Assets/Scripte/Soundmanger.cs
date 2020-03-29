using UnityEngine.Audio;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class Soundmanger : MonoBehaviour
{
    public Sound[] sounds;
    // Start is called before the first frame update
    public static Soundmanger instance;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    void Start()
    {
        // coin_sound=Resources.Load<AudioClip>("Coin-pick-up-sound-effect");
        //  player_jump = Resources.Load<AudioClip>("player_jump");
        //  player_sword_sound = Resources.Load<AudioClip>("sword_sound");
        // audioSrc = GetComponent<AudioSource>();
        Play("Background");
    }

    // Update is called once per frame

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
            return;
        s.source.Play();
    }
}
