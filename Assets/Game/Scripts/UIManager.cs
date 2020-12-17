using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public GameObject m_mainMenuPanel;
    public GameObject m_gameOverPanel;
    public GameObject m_inGameUIPanel;
    public Text m_ScoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int p_score)
    {
        m_ScoreText.text = "Score: " + p_score.ToString();
    }
}
