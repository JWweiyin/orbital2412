using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class arcadeload : MonoBehaviour
{
    public int sceneInd;


    void start()
        {

        }

    public void arcadeloadlevel()
        {
        SceneManager.LoadScene(sceneInd);
        }


    }
