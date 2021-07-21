using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pausemenu : MonoBehaviour
    {
    public GameManager gm;
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject controlsUI;
    public GameObject pauseMenuUI;
    public AudioSource musicSource;
    private int inStory;

    void Start()
        {
        pauseMenuUI.SetActive(false);

        if (gm.levelNbr != 7)
            {
            if (gm.showControls == 1)
                {
                controlsUI.SetActive(true);
                Pause();
                }
            else
                {
                controlsUI.SetActive(false);
                }

            }

        if (gm.levelNbr == 7)
            {
            if (gm.showControls7 == 1)
                {
                Pause();
                controlsUI.SetActive(true);
                }
            else
                {
                controlsUI.SetActive(false);
                }

            }

        }

    public void doNotSee()
        {
        PlayerPrefs.SetInt("Show Controls", 0);
        PlayerPrefs.Save();
        }

    public void doNotSee7()
        {
        PlayerPrefs.SetInt("Show Controls 7", 0);
        PlayerPrefs.Save();
        }


    // Update is called once per frame
    void Update()
        {
        if (Input.GetKeyDown(KeyCode.Escape))
            {
            Debug.Log("Esc Key Pressed");
            if (GameIsPaused)
                {
                Debug.Log("Resume");
                Resume();
                }
            else
                {
                Debug.Log("Paused");
                Pause();
                }
            }
        }


    public void Resume()
        {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        AudioListener.pause = false;
        }

    public void Pause()
        {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        AudioListener.pause = true;
        }

    public void quitStory()
        {
        inStory = 0;
        PlayerPrefs.SetInt("In Story", inStory);
        PlayerPrefs.Save();
        }
    }
