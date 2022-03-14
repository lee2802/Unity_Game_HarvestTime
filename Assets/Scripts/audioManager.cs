using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class audioManager : MonoBehaviour
{
    public SoundLists[] sounds;
  
    void Awake()
    {
        foreach(SoundLists s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

   
    public void Play(string name)
    {
        SoundLists s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.Play();

    
    }

    public void Stop(string name)
    {
        SoundLists s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.Stop();
      
    }

    public void Pause(string name)
    {
        SoundLists s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.Pause();
    }
    public void Resume(string name)
    {
        SoundLists s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.UnPause();
    }


}
