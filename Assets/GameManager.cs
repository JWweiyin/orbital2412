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

    // Start is called before the first frame update
    void Start()
        {
        instance = this;
        perfectHit = 1000000 / no_of_notes;
        goodHit = (int)(perfectHit * 0.75);
        badHit = (int)(perfectHit * 0.5);
        secPerBeat = 60f / songBPM;
        SongTime = (float)AudioSettings.dspTime;
        completeLevelUI.SetActive(false);

        }

    // Update is called once per frame
    void Update()
        {
        songPosition = (float)(AudioSettings.dspTime - SongTime);

        songPositionInBeats = songPosition / secPerBeat;

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
        completeLevelUI.SetActive(true);

 
            amodecompleteUI.SetActive(true);
            


        }
    }
