using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class ChangeMusicVolume : MonoBehaviour
{

    public AudioMixer MasterVolume;

    public void SetMaster(float MasterVol)

    {
        MasterVolume.SetFloat("AudioMix", MasterVol);
    }
}
