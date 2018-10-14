using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class stayTrigger : MonoBehaviour {

    private char ballKey;
    private char knifeKey;
    private char torchKey;
    private char rbtvKey;
    private char raccoonKey;

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

    public int ballTC = 0;

    public Text keyText;

    public int Leben = 3;
    public GameObject[] hearts;

    public AudioSource source1;
    public AudioSource source2;
    public AudioClip verkackt;
    public AudioClip vieh;

    private char chara;

    List<char> needed = new List<char>();
    List<char> charArray = new List<char>();

    void Start()
    {
        ballKey = 'A';
        knifeKey = 'S';
        torchKey = 'D';
        rbtvKey = 'F';
        raccoonKey = 'G';
        

        _highscoreScript = scripts.GetComponent<Points>();
        keyText.text = " ";
    }

    public void TextEnter(int objectT)
    {
        switch (objectT)
        {
            case 0:
                keyText.text = keyText.text + ballKey;
                break;

            case 1:
                keyText.text = keyText.text + knifeKey;
                break;

            case 2:
                keyText.text = keyText.text + torchKey;
                break;

            case 3:
                keyText.text = keyText.text + rbtvKey;
                break;

            case 4:
                keyText.text = keyText.text + raccoonKey;
                break;
        }
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
        Debug.Log("Exit");

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

        for (int i = 0; i < ballClickCount; i++)
        {
            charArray.Add(ballKey);
        }
        for (int i = 0; i < knifeClickCount; i++)
        {
            charArray.Add(knifeKey);
        }
        for (int i = 0; i < torchClickCount; i++)
        {
            charArray.Add(torchKey);
        }
        for (int i = 0; i < rbtvClickCount; i++)
        {
            charArray.Add(rbtvKey);
        }
        for (int i = 0; i < raccoonClickCount; i++)
        {
            charArray.Add(raccoonKey);
        }

        Debug.Log(keyText.text);
        keyText.text = new string(charArray.ToArray());
        charArray = new List<char>();

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
            needed = new List<char>();
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

            if (Input.GetKeyDown(KeyCode.A) && ballClickCount > 0)
            {
                ballClickCount--;
                _highscoreScript.SetPoints(ballPoints);
            }
        }

        if (other.tag == "Knife")
        {
            knifeIn = true;

            if (Input.GetKeyDown(KeyCode.S) && knifeClickCount > 0)
            {
                knifeClickCount--;
                _highscoreScript.SetPoints(knifePoints);
            }
        }

        if (other.tag == "Torch")
        {
            torchIn = true;
            if (Input.GetKeyDown(KeyCode.D) && torchClickCount > 0)
            {
                torchClickCount--;
                _highscoreScript.SetPoints(torchPoints);
            }
        }

        if (other.tag == "RBTV")
        {
            rbtvIn = true;
            if (Input.GetKeyDown(KeyCode.F) && rbtvClickCount > 0)
            {
                rbtvClickCount--;
                _highscoreScript.SetPoints(torchPoints);
            }
        }

        if (other.tag == "Raccoon")
        {
            raccoonIn = true;
            if (Input.GetKeyDown(KeyCode.G) && raccoonClickCount > 0)
            {
                raccoonClickCount--;
                _highscoreScript.SetPoints(raccoonPoints);
                source2.Play();
            }
        }
    }
}