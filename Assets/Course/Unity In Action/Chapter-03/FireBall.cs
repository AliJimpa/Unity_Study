using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed = 10.0f;
    public int damage = 1;


    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) 
    {

        PlayerCharater player = other.GetComponent<PlayerCharater>();
        if (player != null) 
        {
            player.Hurt(damage);
        }

        Destroy(this.gameObject);

    }








}
