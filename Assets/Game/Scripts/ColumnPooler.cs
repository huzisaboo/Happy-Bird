using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPooler : MonoBehaviour
{
    public float m_minY = -2.0f;
    public float m_maxY = 2.0f;
    public int m_poolSize;
    public float m_maxSpawnTime;
    public GameObject m_columnPrefab;
    private GameObject[] m_columnPool;
    private int m_currentColIndex = 0;
    private float m_spawnTimer = 0.0f;
    private float m_yPosValue;
    private float m_xPosValue;
    // Start is called before the first frame update
    void Start()
    {
        m_columnPool = new GameObject[m_poolSize];
        for(int i=0; i<m_columnPool.Length; i++)
        {
            m_columnPool[i] = Instantiate(m_columnPrefab, this.transform);
            m_xPosValue = m_columnPool[i].transform.position.x;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.IsGameStarted())
        {
            m_spawnTimer += Time.deltaTime;
            if(m_spawnTimer >= m_maxSpawnTime)
            {
                m_spawnTimer = 0;
                RepositionColumn(m_currentColIndex);
                m_currentColIndex++;
                if(m_currentColIndex >= m_poolSize)
                {
                    m_currentColIndex = 0;
                }
            }

        }
    }

    private void RepositionColumn(int index)
    {
        m_yPosValue = Random.Range(m_minY, m_maxY);
        m_columnPool[index].transform.position = new Vector2(m_xPosValue, m_yPosValue);
    }
}
