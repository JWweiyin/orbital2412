using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missedNote : MonoBehaviour
{
    public GameManager gm;
    GameObject note;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
        {
        if (col.gameObject.tag == "Note")
            {
            gm.mHit();
            note = col.gameObject;
            if (note)
                {
                Destroy(note);
                }
            }
        }
}
