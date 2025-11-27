using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall2 : MonoBehaviour
{
    public float speed = 10.0f;
    public int damage = 1;


    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) 
    {

        PlayerCharater2 player = other.GetComponent<PlayerCharater2>();
        if (player != null) 
        {
            player.Hurt(damage);
        }

        Destroy(this.gameObject);

    }








}
