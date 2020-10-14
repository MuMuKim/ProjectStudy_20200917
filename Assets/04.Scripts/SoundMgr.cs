using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMgr : MonoBehaviour
{
    public AudioClip audioClip;
    // 사운드
    private AudioSource buttonSound;

    private void Start()
    {
        buttonSound = GetComponent<AudioSource>();
    }
    public void ButtonS()
    {
        buttonSound.clip = audioClip;
        buttonSound.Play();
    }

}
