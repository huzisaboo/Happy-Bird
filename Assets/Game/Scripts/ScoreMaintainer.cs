using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreMaintainer
{
    private static int m_score = 0;

    public  static int Score
    {
        get
        {
            return m_score;
        }

        set
        {
            m_score = value;
        } 
    }
}
