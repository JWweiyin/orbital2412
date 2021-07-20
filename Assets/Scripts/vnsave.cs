using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vnsave : MonoBehaviour
{
    public int lvlInd;



    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Save Point", lvlInd);
        PlayerPrefs.Save();
    }

    public void quitStory()
        {

        PlayerPrefs.SetInt("In Story", 0);
        PlayerPrefs.Save();
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
