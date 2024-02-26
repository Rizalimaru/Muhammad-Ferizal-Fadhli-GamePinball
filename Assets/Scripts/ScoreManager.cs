using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float score;
    void Start()
    {
        ResetScore();
    }

    // Update is called once per frame
    public void AddScore(float addition)
        {
                // tambah skor berdasarkan parameter
            score += addition;
        }

    public void ResetScore()
        {
                // kembalikan skor ke 0 untuk situasi tertentu
            score = 0;
        }
}
