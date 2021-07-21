using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
    {
    public static GameManager instance;
    public bool storymode = false;
    public int currentScore = 0;
    public int currStreak = 0;
    public int bestStreak = 0;
    public int perfectHit;
    public int goodHit;
    public int badHit;
    public int phit = 0;
    public int ghit = 0;
    public int bhit = 0;
    public int miss = 0;
    public int no_of_notes;


    public GameObject completeLevelUI;
    public GameObject amodecompleteUI;
    public GameObject smodecompleteUI;
    public GameObject nextUI;
    public GameObject passfailUI;
    public GameObject restartUI;

    public Text statusText;
    public Text comboText;
    public Text scoreText;

    public float songBPM;
    public float secPerBeat;
    public float songPosition;
    public float songPositionInBeats;
    public float SongTime;
    public AudioSource musicSource;

    public Text ptext;
    public Text gtext;
    public Text btext;
    public Text mtext;
    public Text rscore;
    public Text rcombo;

    public Color perfect;
    public Color good;
    public Color bad;
    public Color missc;

    public int levelNbr;
    public int levelInd;
    public int showControls;
    public int showControls7;
    public int inStory;
    public string clearCode;
    public string hsCode;

    public int cleared;
    public int hs;

    public Text passfail;

    // Start is called before the first frame update
    void Start()
        {
        instance = this;
        musicSource.volume = PlayerPrefs.GetFloat("Music Volume", 1f);
        perfectHit = 1000000 / no_of_notes;
        goodHit = (int)(perfectHit * 0.75);
        badHit = (int)(perfectHit * 0.5);
        secPerBeat = 60f / songBPM;

        completeLevelUI.SetActive(false); 
        amodecompleteUI.SetActive(false);
        smodecompleteUI.SetActive(false);
        passfailUI.SetActive(false);
        restartUI.SetActive(false);
        nextUI.SetActive(false);
        SongTime = (float)AudioSettings.dspTime;

        clearCode = 'c' + levelNbr.ToString();
        hsCode = 'h' + levelNbr.ToString();
        //Debug.Log(clearCode);
        inStory = PlayerPrefs.GetInt("In Story", 0);
        cleared = PlayerPrefs.GetInt(clearCode);
        hs = PlayerPrefs.GetInt(hsCode, 0);

        if (inStory == 1)
            {
            PlayerPrefs.SetInt("Save Point", levelInd);
            PlayerPrefs.Save();
            }


        showControls = PlayerPrefs.GetInt("Show Controls", 1);

        showControls7 = PlayerPrefs.GetInt("Show Controls 7", 1);



        }

    // Update is called once per frame
    void FixedUpdate()
        {
        songPosition = (float)(AudioSettings.dspTime - SongTime);
        songPositionInBeats = songPosition / secPerBeat;


        }
    void Update()
        {
        Debug.Log(songPosition.ToString());
        }

    public void smode()
        {
        storymode = true;
        }

    public void pHit()
        {
        Debug.Log("Perfect hit");
        currentScore += perfectHit;
        currStreak += 1;
        phit += 1;
        statusText.color = perfect;
        statusText.text = "PERFECT";
        scoreText.text = currentScore.ToString();
        comboText.text = currStreak.ToString();
        }

    public void gHit()
        {
        Debug.Log("Good Hit");
        currentScore += goodHit;
        currStreak += 1;
        ghit += 1;
        statusText.color = good;
        statusText.text = "GOOD";
        scoreText.text = currentScore.ToString();
        comboText.text = currStreak.ToString();
        }

    public void bHit()
        {
        Debug.Log("Bad Hit");
        currentScore += badHit;
        if ((currStreak > bestStreak))
            {
            bestStreak = currStreak;
            }
        currStreak = 0;
        bhit += 1;
        statusText.color = bad;
        statusText.text = "BAD";
        scoreText.text = currentScore.ToString();
        comboText.text = currStreak.ToString();
        }

    public void mHit()
        {
        Debug.Log("Miss");
        if ((currStreak > bestStreak))
            {
            bestStreak = currStreak;
            }
        currStreak = 0;
        miss += 1;
        statusText.color = missc;
        statusText.text = "MISS";
        scoreText.text = currentScore.ToString();
        comboText.text = currStreak.ToString();
        }

    public void CompleteLevel()
        {
        ptext.text = phit.ToString();
        gtext.text = ghit.ToString();
        btext.text = bhit.ToString();
        mtext.text = miss.ToString();
        rscore.text = currentScore.ToString();

        rcombo.text = bestStreak.ToString();
        Debug.Log("Level Complete");
        if (currentScore >= 700000)
            {
            passfail.color = perfect;
            passfail.text = "PASSED!";
            } else
            {
            passfail.color = missc;
            passfail.text = "FAILED";
            }
        if (cleared == 0)
            {
            if (currentScore >= 700000)
                {
                cleared = 1;
                PlayerPrefs.SetInt(clearCode, cleared);
                PlayerPrefs.Save();
                }
            }

        if (currentScore > hs)
            {
            PlayerPrefs.SetInt(hsCode, currentScore);
            PlayerPrefs.Save();
            }

        completeLevelUI.SetActive(true);
        passfailUI.SetActive(true);
        restartUI.SetActive(true);

        if (inStory == 0)
            {
            amodecompleteUI.SetActive(true);
            }
        else if (inStory == 1)
            {
            if (cleared == 1)
                {
                nextUI.SetActive(true);
                }
            smodecompleteUI.SetActive(true);
            }

        }

    public void quitStory()
        {
        inStory = 0;
        PlayerPrefs.SetInt("In Story", inStory);
        PlayerPrefs.Save();
        }
    }
