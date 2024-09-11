using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxAudioSource;
    public static VFXManager instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }
    public void PlayVFX(Vector3 spawnPosition)
    {
        // berbeda dengan bgm, disini kita buat script untuk 
        // memunculkan prefabnya pada posisi sesuai dengan parameternya
        GameObject.Instantiate(vfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
