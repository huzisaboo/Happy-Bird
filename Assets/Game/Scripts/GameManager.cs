using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private AudioSource m_audioSource;
    private int m_score;
    private bool m_startGame = false;
    public float m_envMoveSpeed = 5.0f;
    private bool m_highscoreUpdated = false;

    private void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
     
        if(UIManager.Instance.IsMainMenuPanelActive())
        {
            if(!m_highscoreUpdated)
            {
                UIManager.Instance.UpdateHighScore(ScoreMaintainer.Score);
                m_highscoreUpdated = true;

            }
            if (Input.touchCount > 0 && m_startGame == false)
            {
                StartGame();
            }
        }
    }

    private void StartGame()
    {
        m_startGame = true;
        m_score = 0;
        UIManager.Instance.m_mainMenuPanel.SetActive(false);
        UIManager.Instance.m_inGameUIPanel.SetActive(true);
        UIManager.Instance.UpdateScore(m_score);
        UIManager.Instance.m_gameOverPanel.SetActive(false);
    }

    public void EndGame()
    {
        m_startGame = false;
       // UIManager.Instance.m_inGameUIPanel.SetActive(false);
        UIManager.Instance.m_gameOverPanel.SetActive(true);
        if(m_score > ScoreMaintainer.Score)
        {
            ScoreMaintainer.Score = m_score;
        }
    }

    public void IncreaseScore()
    {
        m_score++;
        UIManager.Instance.UpdateScore(m_score);
    }

    public bool IsGameStarted()
    {
       return m_startGame;
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void StopBgMusic()
    {
        if(m_audioSource != null)
        {
            if(m_audioSource.isPlaying)
            {
                m_audioSource.Stop();
            }
        }
    }
}
