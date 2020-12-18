using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BirdAudio : MonoBehaviour
{
    public AudioClip m_flapAudio;
    public AudioClip m_dieAudio;
    private AudioSource m_AudioSource;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    public void PlayFlapAudio()
    {
        if (m_AudioSource != null && m_flapAudio != null)
        {
            m_AudioSource.clip = m_flapAudio;
            m_AudioSource.Play();
        }
    }

    public void PlayDieAudio()
    {
        if (m_AudioSource != null && m_dieAudio != null)
        {
            m_AudioSource.clip = m_dieAudio;
            m_AudioSource.Play();
        }
    }
}
