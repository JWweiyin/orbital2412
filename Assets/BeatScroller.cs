using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;
    public float speed;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, 0f, speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
