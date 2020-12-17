﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BirdMovement : MonoBehaviour
{
    public float m_force;
    Rigidbody2D m_rigidBody;
    private bool m_isDead = false;
    Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody2D>();
        m_animator = GetComponent<Animator>();
        m_rigidBody.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        FlapUpdate();
    }


    private void FlapUpdate()
    {
       
            if (Input.touchCount > 0 && GameManager.Instance.IsGameStarted() && m_isDead == false)
            {
                if (m_rigidBody.isKinematic)
                {
                    m_rigidBody.isKinematic = false;
                }

                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    m_rigidBody.velocity = Vector2.zero;
                    m_rigidBody.AddForce(Vector2.up * m_force);
                    m_animator.SetTrigger("Flap");
                }

            }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        m_isDead = true;
        m_animator.SetTrigger("Dead");
        GameManager.Instance.EndGame();
    }
}
