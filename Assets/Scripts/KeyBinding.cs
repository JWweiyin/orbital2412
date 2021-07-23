using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBinding : MonoBehaviour
{
    private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();

    public Text lane1, lane2, lane3, lane4, lane5, lane6;
    private GameObject currentKey;


    // Start is called before the first frame update
    void Start()
    {
        keys.Add("1", (KeyCode)System.Enum.Parse(typeof(KeyCode),PlayerPrefs.GetString("1", "D")));
        keys.Add("2", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("2", "F")));
        keys.Add("3", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("3", "G")));
        keys.Add("4", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("4", "H")));
        keys.Add("5", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("5", "J")));
        keys.Add("6", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("6", "K")));

        lane1.text = keys["1"].ToString();
        lane2.text = keys["2"].ToString();
        lane3.text = keys["3"].ToString();
        lane4.text = keys["4"].ToString();
        lane5.text = keys["5"].ToString();
        lane6.text = keys["6"].ToString();
        SaveKeys();
        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keys["1"]))
            {
            Debug.Log("Lane 1");
            }
        if (Input.GetKeyDown(keys["2"]))
            {
            Debug.Log("Lane 2");
            }
        if (Input.GetKeyDown(keys["3"]))
            {
            Debug.Log("Lane 3");
            }
        if (Input.GetKeyDown(keys["4"]))
            {
            Debug.Log("Lane 4");
            }
        if (Input.GetKeyDown(keys["5"]))
            {
            Debug.Log("Lane 5");
            }
        if (Input.GetKeyDown(keys["6"]))
            {
            Debug.Log("Lane 6");
            }

        }

    void OnGUI()
        {
        if (currentKey != null)
            {
            Event e = Event.current;
            if (e.isKey)
                {
                keys[currentKey.name] = e.keyCode;
                currentKey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
                currentKey = null;
                }
            }
        }

    public void ChangeKey(GameObject clicked)
        {
        currentKey = clicked;
        }

    public void SaveKeys()
        {
        foreach (var key in keys)
            {
            PlayerPrefs.SetString(key.Key, key.Value.ToString());
            }
        PlayerPrefs.Save();
        }

    public void ResetKeys()
        {
        keys["1"] = KeyCode.D;
        keys["2"] = KeyCode.F;
        keys["3"] = KeyCode.G;
        keys["4"] = KeyCode.H;
        keys["5"] = KeyCode.J;
        keys["6"] = KeyCode.K;

        lane1.text = keys["1"].ToString();
        lane2.text = keys["2"].ToString();
        lane3.text = keys["3"].ToString();
        lane4.text = keys["4"].ToString();
        lane5.text = keys["5"].ToString();
        lane6.text = keys["6"].ToString();

        SaveKeys();
        }
}
