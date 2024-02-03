using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int score;

    public int GetScore()
    {
        return score;
    }

    public void ModifyScore(int value)
    {
        score += value;
        Mathf.Clamp(value, 0, int.MaxValue);
        Debug.Log("Your score:" + score);
    }

    public void ResetScore()
    {
        score = 0;
    }
}
