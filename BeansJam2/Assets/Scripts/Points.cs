using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    public Text scoreText;
    public int highscore = 000000;

	void Start () {

        scoreText.text = highscore.ToString();
	}

    public void SetPoints(int addition)
    {
        highscore = highscore + addition;
        UpdatePoints();
    }

    void UpdatePoints()
    {
        scoreText.text = highscore.ToString();
    }
}
