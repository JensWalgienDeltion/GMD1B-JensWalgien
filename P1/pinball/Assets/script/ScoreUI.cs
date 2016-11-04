using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {

    public int points;
    public ScoreText scoreScript;
    
        //
        void OnCollisionEnter()
    {
        scoreScript.ChangeScore(points);
    }
}
