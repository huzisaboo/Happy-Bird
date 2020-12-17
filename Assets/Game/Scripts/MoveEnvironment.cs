using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnvironment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.IsGameStarted())
        {
            transform.Translate(Vector3.left * Time.deltaTime * GameManager.Instance.m_envMoveSpeed);
        }
    }
}
