using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private int m_score;
    private bool m_startGame = false;
    public float m_envMoveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && m_startGame == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

        UIManager.Instance.m_inGameUIPanel.SetActive(false);
        UIManager.Instance.m_gameOverPanel.SetActive(true);
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
}
