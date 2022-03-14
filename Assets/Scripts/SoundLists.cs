
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class SoundLists 
{
    public AudioClip clip;

    public string name;

    [Range(0f,1f)]
    public float volume;
    [Range(0.3f, 3f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;

    
}
