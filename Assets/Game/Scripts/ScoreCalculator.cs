﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.IncreaseScore();
    }
}
