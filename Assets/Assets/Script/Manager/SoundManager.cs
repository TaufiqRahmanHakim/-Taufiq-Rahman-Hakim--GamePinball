using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private List<AudioClip> clipList;

    public GameObject sfxAudioSource;
    public static SoundManager instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }
    public void PlaySFX(Vector3 spawnPosition)
    {
        // berbeda dengan bgm, disini kita buat script untuk 
        // memunculkan prefabnya pada posisi sesuai dengan parameternya
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

    public void playPaddleAudio()
    {
        audioSource.clip = clipList[0];
        audioSource.Play();
    }
}
