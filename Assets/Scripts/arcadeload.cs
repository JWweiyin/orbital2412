using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class arcadeload : MonoBehaviour
{
    public int level;

    public void arcadeloadlevel()
        {
        SceneManager.LoadScene(level);
        }
    }
