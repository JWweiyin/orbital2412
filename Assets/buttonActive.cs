using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonActive : MonoBehaviour
{
    public Button b;
    public string clearCode;
    private int hasCleared;

    // Start is called before the first frame update
    void Start()
    {
        hasCleared = PlayerPrefs.GetInt(clearCode, 0);
        if (hasCleared == 0)
            {
            b.interactable = false;
            }
        else if (hasCleared == 1)
            {
            b.interactable = true;
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
