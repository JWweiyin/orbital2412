using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vnsave : MonoBehaviour
{
    public int lvlInd;
    public GameObject menub;
    public GameObject dropdown;



    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Save Point", lvlInd);
        PlayerPrefs.Save();
        //menub.SetActive(true);
        //dropdown.SetActive(true);
    }

    public void quitStory()
        {

        PlayerPrefs.SetInt("In Story", 0);
        PlayerPrefs.Save();
        destroyUI();

        }

    public void destroyUI()
        {
        menub.SetActive(false);
        dropdown.SetActive(false);
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
