using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScores : MonoBehaviour
{
    public Text l1, l2, l3, l4, l5, l6, l7, l8;
    // Start is called before the first frame update
    void Start()
    {
        l1.text = PlayerPrefs.GetInt("h1", 0000000).ToString();
        l2.text = PlayerPrefs.GetInt("h2", 0000000).ToString();
        l3.text = PlayerPrefs.GetInt("h3", 0000000).ToString();
        l4.text = PlayerPrefs.GetInt("h4", 0000000).ToString();
        l5.text = PlayerPrefs.GetInt("h5", 0000000).ToString();
        l6.text = PlayerPrefs.GetInt("h6", 0000000).ToString();
        l7.text = PlayerPrefs.GetInt("h7", 0000000).ToString();
        l8.text = PlayerPrefs.GetInt("h8", 0000000).ToString();
        }

    public void resetScores()
        {
        PlayerPrefs.SetInt("h1", 0);
        PlayerPrefs.SetInt("h2", 0);
        PlayerPrefs.SetInt("h3", 0);
        PlayerPrefs.SetInt("h4", 0);
        PlayerPrefs.SetInt("h5", 0);
        PlayerPrefs.SetInt("h6", 0);
        PlayerPrefs.SetInt("h7", 0);
        PlayerPrefs.SetInt("h8", 0);
        PlayerPrefs.Save();

        l1.text = PlayerPrefs.GetInt("h1", 0000000).ToString();
        l2.text = PlayerPrefs.GetInt("h2", 0000000).ToString();
        l3.text = PlayerPrefs.GetInt("h3", 0000000).ToString();
        l4.text = PlayerPrefs.GetInt("h4", 0000000).ToString();
        l5.text = PlayerPrefs.GetInt("h5", 0000000).ToString();
        l6.text = PlayerPrefs.GetInt("h6", 0000000).ToString();
        l7.text = PlayerPrefs.GetInt("h7", 0000000).ToString();
        l8.text = PlayerPrefs.GetInt("h8", 0000000).ToString();
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
