using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stayTrigger : MonoBehaviour {

    private int ballKey;
    private int knifeKey;
    private int torchKey;
    private int rbtvKey;
    private int raccoonKey;

    private int ballCount = 0;
    private bool ballIn = false;
    private int ballClickCount = 0;
    public int ballPoints;

    private int knifeCount = 0;
    private bool knifeIn = false;
    private int knifeClickCount = 0;
    public int knifePoints;

    private int torchCount = 0;
    private bool torchIn = false;
    private int torchClickCount = 0;
    public int torchPoints;

    private int rbtvCount = 0;
    private bool rbtvIn = false;
    private int rbtvClickCount = 0;
    public int rbtvPoints;

    private int raccoonCount = 0;
    private bool raccoonIn = false;
    private int raccoonClickCount = 0;
    public int raccoonPoints;

    public GameObject scripts;
    private Points _highscoreScript;

    void Start()
    {
        ballKey = 0; //Random.Range(0, 12);
        knifeKey = 1; //Random.Range(0, 12);
        torchKey = 2; //Random.Range(0, 12);
        rbtvKey = 3; //Random.Range(0, 12);
        raccoonKey = 4; //Random.Range(0, 12);

        _highscoreScript = scripts.GetComponent<Points>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            ballCount++;
            ballClickCount++;
        }

        if (other.tag == "Knife")
        {
            knifeCount++;
            knifeClickCount++;
        }

        if (other.tag == "Torch")
        {
            torchCount++;
            torchClickCount++;
        }

        if (other.tag == "RBTV")
        {
            rbtvCount++;
            rbtvClickCount++;
        }

        if (other.tag == "Raccoon")
        {
            raccoonCount++;
            raccoonClickCount++;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            ballCount--;
            ballIn = false;
        }

        if (other.tag == "Knife")
        {
            knifeCount--;
            knifeIn = false;
        }

        if (other.tag == "Torch")
        {
            torchCount--;
            torchIn = false;
        }

        if (other.tag == "RBTV")
        {
            rbtvCount--;
            rbtvIn = false;
        }

        if (other.tag == "Raccoon")
        {
            raccoonCount--;
            raccoonIn = false;
        }
    }

    void Update()
    {
        if (ballClickCount > ballCount)
        {
            ballClickCount--;
            Debug.Log("Verkackt!");
        }
        if (knifeClickCount > knifeCount)
        {
            knifeClickCount--;
            Debug.Log("Verkackt!");
        }
        if (torchClickCount > torchCount)
        {
            torchClickCount--;
            Debug.Log("Verkackt!");
        }
        if (rbtvClickCount > rbtvCount)
        {
            rbtvClickCount--;
            Debug.Log("Verkackt!");
        }
        if (raccoonClickCount > raccoonCount)
        {
            raccoonClickCount--;
            Debug.Log("Verkackt!");
        }
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            ballIn = true;
            switch (ballKey)
            {
                case 0:
                    if (Input.GetKeyDown(KeyCode.R) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
                case 1:
                    if (Input.GetKeyDown(KeyCode.G) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.B) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
                case 4:
                    if (Input.GetKeyDown(KeyCode.H) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
                case 5:
                    if (Input.GetKeyDown(KeyCode.U) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
                case 6:
                    if (Input.GetKeyDown(KeyCode.J) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
                case 7:
                    if (Input.GetKeyDown(KeyCode.M) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
                case 8:
                    if (Input.GetKeyDown(KeyCode.K) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
                case 9:
                    if (Input.GetKeyDown(KeyCode.O) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
                case 10:
                    if (Input.GetKeyDown(KeyCode.L) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
                case 11:
                    if (Input.GetKeyDown(KeyCode.P) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
                case 12:
                    if (Input.GetKeyDown(KeyCode.Delete) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                    }
                    break;
            }
        }

        if (other.tag == "Knife")
        {
            knifeIn = true;
            switch (knifeKey)
            {
                case 0:
                    if (Input.GetKeyDown(KeyCode.R) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
                case 1:
                    if (Input.GetKeyDown(KeyCode.G) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.B) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
                case 4:
                    if (Input.GetKeyDown(KeyCode.H) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
                case 5:
                    if (Input.GetKeyDown(KeyCode.U) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
                case 6:
                    if (Input.GetKeyDown(KeyCode.J) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
                case 7:
                    if (Input.GetKeyDown(KeyCode.M) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
                case 8:
                    if (Input.GetKeyDown(KeyCode.K) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
                case 9:
                    if (Input.GetKeyDown(KeyCode.O) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
                case 10:
                    if (Input.GetKeyDown(KeyCode.L) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
                case 11:
                    if (Input.GetKeyDown(KeyCode.P) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
                case 12:
                    if (Input.GetKeyDown(KeyCode.Delete) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                    }
                    break;
            }
        }

        if (other.tag == "torch")
        {
            torchIn = true;
            switch (torchKey)
            {
                case 0:
                    if (Input.GetKeyDown(KeyCode.R) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 1:
                    if (Input.GetKeyDown(KeyCode.G) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.B) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 4:
                    if (Input.GetKeyDown(KeyCode.H) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 5:
                    if (Input.GetKeyDown(KeyCode.U) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 6:
                    if (Input.GetKeyDown(KeyCode.J) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 7:
                    if (Input.GetKeyDown(KeyCode.M) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 8:
                    if (Input.GetKeyDown(KeyCode.K) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 9:
                    if (Input.GetKeyDown(KeyCode.O) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 10:
                    if (Input.GetKeyDown(KeyCode.L) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 11:
                    if (Input.GetKeyDown(KeyCode.P) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 12:
                    if (Input.GetKeyDown(KeyCode.Delete) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
            }
        }

        if (other.tag == "RBTV")
        {
            rbtvIn = true;
            switch (rbtvKey)
            {
                case 0:
                    if (Input.GetKeyDown(KeyCode.R) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 1:
                    if (Input.GetKeyDown(KeyCode.G) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.B) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 4:
                    if (Input.GetKeyDown(KeyCode.H) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 5:
                    if (Input.GetKeyDown(KeyCode.U) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 6:
                    if (Input.GetKeyDown(KeyCode.J) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 7:
                    if (Input.GetKeyDown(KeyCode.M) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                    }
                    _highscoreScript.SetPoints(torchPoints);
                    break;
                case 8:
                    if (Input.GetKeyDown(KeyCode.K) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 9:
                    if (Input.GetKeyDown(KeyCode.O) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 10:
                    if (Input.GetKeyDown(KeyCode.L) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 11:
                    if (Input.GetKeyDown(KeyCode.P) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
                case 12:
                    if (Input.GetKeyDown(KeyCode.Delete) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                    }
                    break;
            }
        }

        if (other.tag == "Raccoon")
        {
            raccoonIn = true;
            switch (raccoonKey)
            {
                case 0:
                    if (Input.GetKeyDown(KeyCode.R) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
                case 1:
                    if (Input.GetKeyDown(KeyCode.G) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.B) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
                case 4:
                    if (Input.GetKeyDown(KeyCode.H) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
                case 5:
                    if (Input.GetKeyDown(KeyCode.U) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
                case 6:
                    if (Input.GetKeyDown(KeyCode.J) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
                case 7:
                    if (Input.GetKeyDown(KeyCode.M) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
                case 8:
                    if (Input.GetKeyDown(KeyCode.K) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
                case 9:
                    if (Input.GetKeyDown(KeyCode.O) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
                case 10:
                    if (Input.GetKeyDown(KeyCode.L) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
                case 11:
                    if (Input.GetKeyDown(KeyCode.P) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
                case 12:
                    if (Input.GetKeyDown(KeyCode.Delete) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                    }
                    break;
            }
        }
    }
}
