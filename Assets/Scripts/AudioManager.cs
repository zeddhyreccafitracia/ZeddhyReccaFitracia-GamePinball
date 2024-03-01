using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxBumperAudioSource;

    public GameObject sfxSwitchAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
        
    }

    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFXBumper(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxBumperAudioSource, spawnPosition, Quaternion.identity);
    }
    
    public void PlaySFXSwitch(Vector3 spawnPosition)    
    {
        GameObject.Instantiate(sfxSwitchAudioSource, spawnPosition, Quaternion.identity);
    }
}
