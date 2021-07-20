using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSave : MonoBehaviour
{
    private Dictionary<string, int> cleared = new Dictionary<string, int>();
    private Dictionary<string, int> highScore = new Dictionary<string, int>();
    private int savePoint;
    private int showControls;
    private int inStory;
    private int level;

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

        savePoint = 3;
        showControls = 1;
        inStory = 0;
        }

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
        PlayerPrefs.SetInt("Save Point", savePoint);
        PlayerPrefs.SetInt("Show Controls", showControls);
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
    
// Update is called once per frame
void Update()
    {
        
    }
}
