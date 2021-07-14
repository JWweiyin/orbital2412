using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pausemenu : MonoBehaviour
    {
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public AudioSource musicSource;

    void Start()
        {
        pauseMenuUI.SetActive(false);
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
    }
