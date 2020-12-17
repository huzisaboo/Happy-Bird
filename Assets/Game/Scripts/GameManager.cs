using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private bool m_startGame = false;
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
        UIManager.Instance.m_mainMenuPanel.SetActive(false);
        UIManager.Instance.m_inGameUIPanel.SetActive(true);
        UIManager.Instance.m_gameOverPanel.SetActive(false);
    }

    public void EndGame()
    {
        m_startGame = false;

        UIManager.Instance.m_inGameUIPanel.SetActive(false);
        UIManager.Instance.m_gameOverPanel.SetActive(true);
    }
}
