using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    AudioSource m_audioSource;

    private void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.IncreaseScore();
        if(m_audioSource != null)
        {
            m_audioSource.Play();
        }
      
    }
}
