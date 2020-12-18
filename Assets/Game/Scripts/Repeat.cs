using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeat : MonoBehaviour
{
    SpriteRenderer m_spriteRenderer;
    private float m_horizontalLength;
    // Start is called before the first frame update
    void Start()
    {
        m_spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        m_horizontalLength = m_spriteRenderer.sprite.bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -m_horizontalLength)
        {
            RePositionBg();
        }
    }

    private void RePositionBg()
    {   
        Vector3 a_offset = new Vector3(m_horizontalLength * 2.0f, 0,0); //Skip one bg and position on the next one
        transform.position += a_offset;
    }
}
