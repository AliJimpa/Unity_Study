using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip HitingBox;
    public AudioClip PickingLight;


    private AudioSource Speaker;
    private float speed = 20;
    private float turnSpeed =45.0f;
    private float horizontalnput;
    private float forwardInput;

    private void Awake() {
        Speaker = GetComponent<AudioSource>();
    }

    void Update()
    {
        horizontalnput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up , turnSpeed*horizontalnput * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other) {
        
        if (other.rigidbody)
        {
            Speaker.clip = HitingBox;
            Speaker.Play();
        }

    }

    private void OnTriggerEnter(Collider other) {
        if (other != null)
        {
            Speaker.clip = PickingLight;
            Speaker.Play();
            Destroy(other.gameObject);
        }
    }


}
