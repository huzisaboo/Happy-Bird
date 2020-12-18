using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnvironment : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.IsGameStarted())
        {
            transform.Translate(Vector3.left * Time.deltaTime * GameManager.Instance.m_envMoveSpeed);
        }
    }
}
