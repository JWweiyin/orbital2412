using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;
    public float speed;
    public float speed2;
    public GameManager gm;
    public float beatToHit;

    public float timeLeft;
    public float distLeft;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
        rb = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        distLeft = rb.transform.position.z;

        if (distLeft <= -0.01)
            {
            timeLeft = (beatToHit - gm.songPositionInBeats) * gm.secPerBeat;
            distLeft = rb.transform.position.z;
            speed = Mathf.Abs(distLeft / timeLeft);
            rb.velocity = new Vector3(0f, 0f, speed);
            }
        else
            {
            rb.velocity = new Vector3(0f, 0f, speed2);
            }

     }
}
