using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public AudioSource audioMic;
    private Animator animator;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mic")
        {
            audioMic.Play();
            animator.SetTrigger("MicGet");
            collision.gameObject.SetActive(false);
        }
    }
}
