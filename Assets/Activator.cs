using System.Collections;
using UnityEngine;

public class Activator : MonoBehaviour
    {
    public KeyCode key;
    bool active = false;
    GameObject note;

    // Start is called before the first frame update
    void Start()
        {

        }

    // Update is called once per frame
    void Update()
        {
 
        if (Input.GetKeyDown(key) && active)
            {
            Destroy(note);
            }

        }

    void OnTriggerEnter(Collider col)
        {
        active = true;
        if (col.gameObject.tag == "Note")
            {
 
            note = col.gameObject;
            }
        }

    void OnTriggerExit(Collider col)
        {
        active = false;
        }
    }
