using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    public Text scoretext;
    int score;

    public void ChangeScore(int points)
    {
        score += points;
        scoretext.text = score.ToString();
    }
}
