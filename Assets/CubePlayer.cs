using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayer : MonoBehaviour
{


    Rigidbody2D rigid2D;
    private AudioSource audioSource;
    private bool isInAir = true;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        audioSource = gameObject.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        if (rigid2D.velocity.y > 0 && isInAir)
        {
            audioSource.Play();
            isInAir = false;
        }
    }
}

