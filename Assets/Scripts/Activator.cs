using System.Collections;
using UnityEngine;

public class Activator : MonoBehaviour
    {
    public KeyCode key;
    bool active = false;
    //bool perfect = false;
    //bool good = false;
    GameObject note;
    public GameManager gm;
    private AudioSource source;


    
    
    // Start is called before the first frame update
    void Start()
        {
        source = GetComponent<AudioSource>();
        }

    // Update is called once per frame
    void Update()
        {

        if (Input.GetKeyDown(key) && active)
            {
            if (note.transform.position.z <= 0.50f && note.transform.position.z >= -0.50f)
                {
                gm.pHit();
                if (note){
                    Destroy(note);
                    }
                }
            else if (note.transform.position.z <= 1.00f && note.transform.position.z >= -1.00f)
                {
                gm.gHit();
                if (note){
                    Destroy(note);
                    }
                }
            else
                {
                gm.bHit();
                if (note){
                    Destroy(note);
                    }
                }
            active = false;
            }


        if (Input.GetKeyDown(key))
            {
            source.Play();
            }

        }

    void OnTriggerEnter(Collider col)
        {


        if (col.gameObject.tag == "Note")
            {
            active = true;
            note = col.gameObject;
            }
        
        if (col.gameObject.tag == "END")
            {
            gm.CompleteLevel();
            Debug.Log("Level End");
            }

        }

    void OnTriggerExit(Collider col)
        {
        active = false;
        }

    }
