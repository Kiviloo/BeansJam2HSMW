using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    public Text scoreText;
    public int highscore = 000000;
    public AudioSource source;
    public AudioClip sound;

	void Start () {

        scoreText.text = highscore.ToString();
	}

    public void SetPoints(int addition)
    {
        highscore = highscore + addition;
        UpdatePoints();

        source.volume = 0.5f;
        source.clip = sound;
        source.Play();
    }

    void UpdatePoints()
    {
        scoreText.text = highscore.ToString();
    }


}
