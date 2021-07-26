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
    public ParticleSystem ps;

    public Color perfect;
    public Color good;
    public Color bad;

    public int laneint;
    private string keystring;
    public GameObject end;



    // Start is called before the first frame update
    void Start()
        {
        source = GetComponent<AudioSource>();
        keystring = laneint.ToString();
        key = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString(keystring));
        source.volume = PlayerPrefs.GetFloat("SFX Volume", 1f);
        }

    // Update is called once per frame
    void Update()
        {

        var main = ps.main;

        if (Input.GetKeyDown(key) && active)
            {
            if (note.transform.position.z <= -0.50f && note.transform.position.z >= -1.50f)
                {
                gm.pHit();
                main.startColor = perfect;
                ps.Play();
                if (note){
                    Destroy(note);
                    }
                }
            else if (note.transform.position.z <= 0.00f && note.transform.position.z >= -2.00f)
                {
                gm.gHit();
                main.startColor = good;
                ps.Play();
                if (note){
                    Destroy(note);
                    }
                }
            else
                {
                gm.bHit();
                main.startColor = bad;
                ps.Play();
                if (note){
                    Destroy(note);
                    }
                }
            active = false;
            }


        if (Input.GetKeyDown(key))
            {
            source.Play();
            //ps.Play();
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
            Destroy(end);
            gm.CompleteLevel();
            Debug.Log("Level End");
            }

        }

    void OnTriggerExit(Collider col)
        {
        active = false;
        }

    }
