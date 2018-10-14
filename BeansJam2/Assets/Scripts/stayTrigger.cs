using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public Text keyText;

    public int Leben = 3;
    public GameObject[] hearts;

    public AudioSource source1;
    public AudioSource source2;
    public AudioClip verkackt;
    public AudioClip vieh;

    void Start()
    {
        List<int> allNumbers = new List<int>();

        for (int x = 0; x < 5; x++)
        {
            int ranNum = Random.Range(0, 11);
            
            while (allNumbers.Contains(ranNum))
            {
                ranNum = Random.Range(0, 11);
            }

            allNumbers.Add(ranNum);

            if (x == 0)
            {
                ballKey = ranNum;
            }
            if (x == 1)
            {
                knifeKey = ranNum;
            }
            if (x == 2)
            {
                torchKey = ranNum;
            }
            if (x == 3)
            {
                rbtvKey = ranNum;
            }
            if (x == 4)
            {
                raccoonKey = ranNum;
            }
        }

        _highscoreScript = scripts.GetComponent<Points>();
        keyText.text = " ";
    }

    public void TextEnter(int objectT)
    {
        switch (objectT)
        {
            case 0:
                switch (ballKey)
                {
                    case 0:
                        keyText.text = keyText.text + "R";
                        break;
                    case 1:
                        keyText.text = keyText.text + "G";
                        break;
                    case 2:
                        keyText.text = keyText.text + "B";
                        break;
                    case 3:
                        keyText.text = keyText.text + "H";
                        break;
                    case 4:
                        keyText.text = keyText.text + "U";
                        break;
                    case 5:
                        keyText.text = keyText.text + "J";
                        break;
                    case 6:
                        keyText.text = keyText.text + "M";
                        break;
                    case 7:
                        keyText.text = keyText.text + "K";
                        break;
                    case 8:
                        keyText.text = keyText.text + "O";
                        break;
                    case 9:
                        keyText.text = keyText.text + "L";
                        break;
                    case 10:
                        keyText.text = keyText.text + "P";
                        break;
                }
                break;

            case 1:
                switch (knifeKey)
                {
                    case 0:
                        keyText.text = keyText.text + "R";
                        break;
                    case 1:
                        keyText.text = keyText.text + "G";
                        break;
                    case 2:
                        keyText.text = keyText.text + "B";
                        break;
                    case 3:
                        keyText.text = keyText.text + "H";
                        break;
                    case 4:
                        keyText.text = keyText.text + "U";
                        break;
                    case 5:
                        keyText.text = keyText.text + "J";
                        break;
                    case 6:
                        keyText.text = keyText.text + "M";
                        break;
                    case 7:
                        keyText.text = keyText.text + "K";
                        break;
                    case 8:
                        keyText.text = keyText.text + "O";
                        break;
                    case 9:
                        keyText.text = keyText.text + "L";
                        break;
                    case 10:
                        keyText.text = keyText.text + "P";
                        break;
                }
                break;

            case 2:
                switch (torchKey)
                {
                    case 0:
                        keyText.text = keyText.text + "R";
                        break;
                    case 1:
                        keyText.text = keyText.text + "G";
                        break;
                    case 2:
                        keyText.text = keyText.text + "B";
                        break;
                    case 3:
                        keyText.text = keyText.text + "H";
                        break;
                    case 4:
                        keyText.text = keyText.text + "U";
                        break;
                    case 5:
                        keyText.text = keyText.text + "J";
                        break;
                    case 6:
                        keyText.text = keyText.text + "M";
                        break;
                    case 7:
                        keyText.text = keyText.text + "K";
                        break;
                    case 8:
                        keyText.text = keyText.text + "O";
                        break;
                    case 9:
                        keyText.text = keyText.text + "L";
                        break;
                    case 10:
                        keyText.text = keyText.text + "P";
                        break;
                }
                break;

            case 3:
                switch (rbtvKey)
                {
                    case 0:
                        keyText.text = keyText.text + "R";
                        break;
                    case 1:
                        keyText.text = keyText.text + "G";
                        break;
                    case 2:
                        keyText.text = keyText.text + "B";
                        break;
                    case 3:
                        keyText.text = keyText.text + "H";
                        break;
                    case 4:
                        keyText.text = keyText.text + "U";
                        break;
                    case 5:
                        keyText.text = keyText.text + "J";
                        break;
                    case 6:
                        keyText.text = keyText.text + "M";
                        break;
                    case 7:
                        keyText.text = keyText.text + "K";
                        break;
                    case 8:
                        keyText.text = keyText.text + "O";
                        break;
                    case 9:
                        keyText.text = keyText.text + "L";
                        break;
                    case 10:
                        keyText.text = keyText.text + "P";
                        break;
                }
                break;

            case 4:
                switch (raccoonKey)
                {
                    case 0:
                        keyText.text = keyText.text + "R";
                        break;
                    case 1:
                        keyText.text = keyText.text + "G";
                        break;
                    case 2:
                        keyText.text = keyText.text + "B";
                        break;
                    case 3:
                        keyText.text = keyText.text + "H";
                        break;
                    case 4:
                        keyText.text = keyText.text + "U";
                        break;
                    case 5:
                        keyText.text = keyText.text + "J";
                        break;
                    case 6:
                        keyText.text = keyText.text + "M";
                        break;
                    case 7:
                        keyText.text = keyText.text + "K";
                        break;
                    case 8:
                        keyText.text = keyText.text + "O";
                        break;
                    case 9:
                        keyText.text = keyText.text + "L";
                        break;
                    case 10:
                        keyText.text = keyText.text + "P";
                        break;
                }
                break;
        }
    }

    public void TextExit()
    {
        string tmp = keyText.text;
        if (keyText.text.Length != 0)
        {
            tmp = tmp.Substring(1, tmp.Length - 1);
            keyText.text = tmp;
        }
        
    }

    public void TextExitCertain(char wanted)
    {
        List<char> needed = new List<char>();

        for (int x = 0; x < keyText.text.Length; x++)
        {
            needed.Add(keyText.text[x]);
        }

        for (int i = 0; i < keyText.text.Length; i++)
        {
            if (wanted.Equals(needed[i]))
            {
                needed.Remove(needed[i]);
            }
        }

        string newstr = new string(needed.ToArray());

        keyText.text = newstr;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            ballCount++;
            ballClickCount++;
            TextEnter(0);
        }

        if (other.tag == "Knife")
        {
            knifeCount++;
            knifeClickCount++;
            TextEnter(1);
        }

        if (other.tag == "Torch")
        {
            torchCount++;
            torchClickCount++;
            TextEnter(2);
        }

        if (other.tag == "RBTV")
        {
            rbtvCount++;
            rbtvClickCount++;
            TextEnter(3);
        }

        if (other.tag == "Raccoon")
        {
            raccoonCount++;
            raccoonClickCount++;
            TextEnter(4);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        TextExit();
        if (other.tag == "Ball")
        {
            ballCount--;
            ballIn = false;

            FallDown(other);
        }

        if (other.tag == "Knife")
        {
            knifeCount--;
            knifeIn = false;

            FallDown(other);
        }

        if (other.tag == "Torch")
        {
            torchCount--;
            torchIn = false;

            FallDown(other);
        }

        if (other.tag == "RBTV")
        {
            rbtvCount--;
            rbtvIn = false;

            FallDown(other);
        }

        if (other.tag == "Raccoon")
        {
            raccoonCount--;
            raccoonIn = false;

            FallDown(other);
        }
    }

    void FallDown(Collider2D other)
    {
        if (ballClickCount > ballCount)
        {
            Rigidbody2D body = other.attachedRigidbody;
            body.bodyType = RigidbodyType2D.Dynamic;
        }
        if (knifeClickCount > knifeCount)
        {
            Rigidbody2D body = other.attachedRigidbody;
            body.bodyType = RigidbodyType2D.Dynamic;
        }
        if (torchClickCount > torchCount)
        {
            Rigidbody2D body = other.attachedRigidbody;
            body.bodyType = RigidbodyType2D.Dynamic;
        }
        if (rbtvClickCount > rbtvCount)
        {
            Rigidbody2D body = other.attachedRigidbody;
            body.bodyType = RigidbodyType2D.Dynamic;
        }
        if (raccoonClickCount > raccoonCount)
        {
            Rigidbody2D body = other.attachedRigidbody;
            body.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    void Update()
    {
        if (ballClickCount > ballCount)
        {
            ballClickCount--;
            MinusLeben();
        }
        if (knifeClickCount > knifeCount)
        {
            knifeClickCount--;
            MinusLeben();
        }
        if (torchClickCount > torchCount)
        {
            torchClickCount--;
            MinusLeben();
        }
        if (rbtvClickCount > rbtvCount)
        {
            rbtvClickCount--;
            MinusLeben();
        }
        if (raccoonClickCount > raccoonCount)
        {
            raccoonClickCount--;
            MinusLeben();
        }

        if (ballCount == 0 && knifeCount == 0 && torchCount == 0 && rbtvCount == 0 && raccoonCount == 0)
        {
            keyText.text = "";
        }


    }

    public void MinusLeben()
    {
        if (Leben <= 0)
        {
            SceneManager.LoadScene("DeathScreen");
        }
        Leben--;

        hearts[Leben].SetActive(false);

        source1.volume = 1f;
        source1.clip = verkackt;
        source1.Play();

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
                        TextExitCertain('R');
                    }
                    break;
                case 1:
                    if (Input.GetKeyDown(KeyCode.G) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                        TextExitCertain('G');
                    }
                    break;
                case 2:
                    if (Input.GetKeyDown(KeyCode.B) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                        TextExitCertain('B');
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.H) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                        TextExitCertain('H');
                    }
                    break;
                case 4:
                    if (Input.GetKeyDown(KeyCode.U) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                        TextExitCertain('U');
                    }
                    break;
                case 5:
                    if (Input.GetKeyDown(KeyCode.J) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                        TextExitCertain('J');
                    }
                    break;
                case 6:
                    if (Input.GetKeyDown(KeyCode.M) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                        TextExitCertain('M');
                    }
                    break;
                case 7:
                    if (Input.GetKeyDown(KeyCode.K) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                        TextExitCertain('K');
                    }
                    break;
                case 8:
                    if (Input.GetKeyDown(KeyCode.O) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                        TextExitCertain('O');
                    }
                    break;
                case 9:
                    if (Input.GetKeyDown(KeyCode.L) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                        TextExitCertain('L');
                    }
                    break;
                case 10:
                    if (Input.GetKeyDown(KeyCode.P) && ballClickCount > 0)
                    {
                        ballClickCount--;
                        _highscoreScript.SetPoints(ballPoints);
                        TextExitCertain('P');
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
                        TextExitCertain('R');
                    }
                    break;
                case 1:
                    if (Input.GetKeyDown(KeyCode.G) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                        TextExitCertain('G');
                    }
                    break;
                case 2:
                    if (Input.GetKeyDown(KeyCode.B) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                        TextExitCertain('B');
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.H) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                        TextExitCertain('H');
                    }
                    break;
                case 4:
                    if (Input.GetKeyDown(KeyCode.U) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                        TextExitCertain('U');
                    }
                    break;
                case 5:
                    if (Input.GetKeyDown(KeyCode.J) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                        TextExitCertain('J');
                    }
                    break;
                case 6:
                    if (Input.GetKeyDown(KeyCode.M) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                        TextExitCertain('M');
                    }
                    break;
                case 7:
                    if (Input.GetKeyDown(KeyCode.K) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                        TextExitCertain('K');
                    }
                    break;
                case 8:
                    if (Input.GetKeyDown(KeyCode.O) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                        TextExitCertain('O');
                    }
                    break;
                case 9:
                    if (Input.GetKeyDown(KeyCode.L) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                        TextExitCertain('L');
                    }
                    break;
                case 10:
                    if (Input.GetKeyDown(KeyCode.P) && knifeClickCount > 0)
                    {
                        knifeClickCount--;
                        _highscoreScript.SetPoints(knifePoints);
                        TextExitCertain('P');
                    }
                    break;
            }
        }

        if (other.tag == "Torch")
        {
            torchIn = true;
            switch (torchKey)
            {
                case 0:
                    if (Input.GetKeyDown(KeyCode.R) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('R');
                    }
                    break;
                case 1:
                    if (Input.GetKeyDown(KeyCode.G) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('G');
                    }
                    break;
                case 2:
                    if (Input.GetKeyDown(KeyCode.B) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('B');
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.H) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('H');
                    }
                    break;
                case 4:
                    if (Input.GetKeyDown(KeyCode.U) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('U');
                    }
                    break;
                case 5:
                    if (Input.GetKeyDown(KeyCode.J) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('J');
                    }
                    break;
                case 6:
                    if (Input.GetKeyDown(KeyCode.M) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('M');
                    }
                    break;
                case 7:
                    if (Input.GetKeyDown(KeyCode.K) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('K');
                    }
                    break;
                case 8:
                    if (Input.GetKeyDown(KeyCode.O) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('O');
                    }
                    break;
                case 9:
                    if (Input.GetKeyDown(KeyCode.L) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('L');
                    }
                    break;
                case 10:
                    if (Input.GetKeyDown(KeyCode.P) && torchClickCount > 0)
                    {
                        torchClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('P');
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
                        TextExitCertain('R');
                    }
                    break;
                case 1:
                    if (Input.GetKeyDown(KeyCode.G) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('G');
                    }
                    break;
                case 2:
                    if (Input.GetKeyDown(KeyCode.B) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('B');
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.H) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('H');
                    }
                    break;
                case 4:
                    if (Input.GetKeyDown(KeyCode.U) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('U');
                    }
                    break;
                case 5:
                    if (Input.GetKeyDown(KeyCode.J) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('J');
                    }
                    break;
                case 6:
                    if (Input.GetKeyDown(KeyCode.M) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('M');
                    }
                    break;
                case 7:
                    if (Input.GetKeyDown(KeyCode.K) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('K');
                    }
                    break;
                case 8:
                    if (Input.GetKeyDown(KeyCode.O) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('O');
                    }
                    break;
                case 9:
                    if (Input.GetKeyDown(KeyCode.L) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('L');
                    }
                    break;
                case 10:
                    if (Input.GetKeyDown(KeyCode.P) && rbtvClickCount > 0)
                    {
                        rbtvClickCount--;
                        _highscoreScript.SetPoints(torchPoints);
                        TextExitCertain('P');
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
                        TextExitCertain('R');
                        source2.Play();
                    }
                    break;
                case 1:
                    if (Input.GetKeyDown(KeyCode.G) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                        TextExitCertain('G');
                        source2.Play();
                    }
                    break;
                case 2:
                    if (Input.GetKeyDown(KeyCode.B) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                        TextExitCertain('B');
                        source2.Play();
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.H) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                        TextExitCertain('H');
                        source2.Play();
                    }
                    break;
                case 4:
                    if (Input.GetKeyDown(KeyCode.U) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                        TextExitCertain('U');
                        source2.Play();

                    }
                    break;
                case 5:
                    if (Input.GetKeyDown(KeyCode.J) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                        TextExitCertain('J');
                        source2.Play();
                    }
                    break;
                case 6:
                    if (Input.GetKeyDown(KeyCode.M) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                        TextExitCertain('M');
                        source2.Play();
                    }
                    break;
                case 7:
                    if (Input.GetKeyDown(KeyCode.K) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                        TextExitCertain('K');
                        source2.Play();
                    }
                    break;
                case 8:
                    if (Input.GetKeyDown(KeyCode.O) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                        TextExitCertain('O');
                        source2.Play();
                    }
                    break;
                case 9:
                    if (Input.GetKeyDown(KeyCode.L) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                        TextExitCertain('L');
                        source2.Play();
                    }
                    break;
                case 10:
                    if (Input.GetKeyDown(KeyCode.P) && raccoonClickCount > 0)
                    {
                        raccoonClickCount--;
                        _highscoreScript.SetPoints(raccoonPoints);
                        TextExitCertain('P');
                        source2.Play();
                    }
                    break;
            }
        }
    }
}