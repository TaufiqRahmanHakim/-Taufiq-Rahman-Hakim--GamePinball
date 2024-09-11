using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private List<AudioClip> clipList;
    public static SoundManager instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }

    public void playBumperAudio()
    {
        audioSource.clip = clipList[0];
        audioSource.Play();
    }
    public void playPaddleAudio()
    {
        audioSource.clip = clipList[1];
        audioSource.Play();
    }
}
