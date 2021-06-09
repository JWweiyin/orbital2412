using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
    {
    public static GameManager instance;
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
    public Text statusText;

    public float songBPM;
    public float secPerBeat;
    public float songPosition;
    public float songPositionInBeats;
    public float SongTime;
    public AudioSource musicSource;

    // Start is called before the first frame update
    void Start()
        {
        instance = this;
        perfectHit = 1000000 / no_of_notes;
        goodHit = (int)(perfectHit * 0.75);
        badHit = (int)(perfectHit * 0.5);
        completeLevelUI.SetActive(false);

        secPerBeat = 60f / songBPM;
        SongTime = (float)AudioSettings.dspTime;
        }

    // Update is called once per frame
    void Update()
        {
        songPosition = (float)(AudioSettings.dspTime - SongTime);

        songPositionInBeats = songPosition / secPerBeat;

        }

    public void pHit()
        {
        Debug.Log("Perfect hit");
        currentScore += perfectHit;
        currStreak += 1;
        phit += 1;
        statusText.text = "PERFECT";
        }

    public void gHit()
        {
        Debug.Log("Good Hit");
        currentScore += goodHit;
        currStreak += 1;
        ghit += 1;
        statusText.text = "GOOD";
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
        statusText.text = "BAD";
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
        statusText.text = "MISS";
        }

    public void CompleteLevel()
        {
        Debug.Log("Level Complete");
        completeLevelUI.SetActive(true);
        }
    }
