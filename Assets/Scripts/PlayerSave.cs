using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSave : MonoBehaviour
{
    private Dictionary<string, int> cleared = new Dictionary<string, int>();
    private Dictionary<string, int> highScore = new Dictionary<string, int>();
    private Dictionary<string, int> attempts = new Dictionary<string, int>();
    private int savePoint;
    private int showControls;
    private int showControls7;
    private int inStory;
    private int level;
    public int hasFile;
    public Button b;

    public void SaveProgress()
        {
        foreach (var key in cleared)
            {
            PlayerPrefs.SetInt(key.Key, key.Value);
            }
        foreach (var key in highScore)
            {
            PlayerPrefs.SetInt(key.Key, key.Value);
            }
        foreach (var key in attempts)
            {
            PlayerPrefs.SetInt(key.Key, key.Value);
            }
        PlayerPrefs.SetInt("Save Point", savePoint);
        PlayerPrefs.SetInt("Show Controls", showControls);
        PlayerPrefs.Save();
        }
    // Start is called before the first frame update
    void Start()
    {
        cleared.Add("c1", 0);
        cleared.Add("c2", 0);
        cleared.Add("c3", 0);
        cleared.Add("c4", 0);
        cleared.Add("c5", 0);
        cleared.Add("c6", 0);
        cleared.Add("c7", 0);
        cleared.Add("c8", 0);

        highScore.Add("h1", 0000000);
        highScore.Add("h2", 0000000);
        highScore.Add("h3", 0000000);
        highScore.Add("h4", 0000000);
        highScore.Add("h5", 0000000);
        highScore.Add("h6", 0000000);
        highScore.Add("h7", 0000000);
        highScore.Add("h8", 0000000);

        attempts.Add("a1", 0);
        attempts.Add("a2", 0);
        attempts.Add("a3", 0);
        attempts.Add("a4", 0);
        attempts.Add("a5", 0);
        attempts.Add("a6", 0);
        attempts.Add("a7", 0);
        attempts.Add("a8", 0);

        savePoint = 3;
        showControls = 1;
        showControls7 = 1;
        hasFile = 0;
        inStory = 0;

        hasFile = PlayerPrefs.GetInt("Has File", 0);

        if (hasFile == 0)
            {
            b.interactable = false;
            }
        else if (hasFile == 1)
            {
            b.interactable = true;
            }

       // SaveProgress();
        }



    public void saveMade()
        {
        hasFile = 1;
        PlayerPrefs.SetInt("Has File", 1);
        PlayerPrefs.Save();
        }


    public void enterStory()
        {
        inStory = 1;
        PlayerPrefs.SetInt("In Story", inStory);
        PlayerPrefs.Save();
        }

    public void quitStory()
        {
        inStory = 0;
        PlayerPrefs.SetInt("In Story", inStory);
        PlayerPrefs.Save();
        }

    public void loadLevel()
        {
        level = PlayerPrefs.GetInt("Save Point", 3);      
        SceneManager.LoadScene(level);
        }
    
    public void deleteData()
        {
        foreach (var key in cleared)
            {
            PlayerPrefs.SetInt(key.Key, 0);
            }
        foreach (var key in highScore)
            {
            PlayerPrefs.SetInt(key.Key, 0);
            }
        foreach (var key in attempts)
            {
            PlayerPrefs.SetInt(key.Key, 0);
            }
        PlayerPrefs.SetInt("Save Point", 3);
        PlayerPrefs.SetInt("Show Controls", 1);
        PlayerPrefs.SetInt("Show Controls 7", 1);
        PlayerPrefs.SetInt("Has File", 0);
        PlayerPrefs.Save();
        }

}
