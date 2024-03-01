using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxBumperAudioSource;
    public GameObject vfxSwitchAudioSource;
    public void PlayVFXBumper(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxBumperAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlayVFXSwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSwitchAudioSource, spawnPosition, Quaternion.identity);
    }

}
