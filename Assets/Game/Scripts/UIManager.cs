using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public GameObject m_mainMenuPanel;
    public GameObject m_gameOverPanel;
    public GameObject m_inGameUIPanel;
    public Text m_ScoreText;
    public Text m_HighScoreText;

    public void UpdateScore(int p_score)
    {
        m_ScoreText.text = "Score: " + p_score.ToString();
    }

    public void UpdateHighScore(int p_highScore)
    {
        m_HighScoreText.text = "High Score: " + p_highScore.ToString();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public bool IsGameOverPanelActive()
    {
        return m_gameOverPanel.activeInHierarchy;
    }

    public bool IsMainMenuPanelActive()
    {
        return m_mainMenuPanel.activeInHierarchy;
    }
}
