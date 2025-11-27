using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject Projectileprefab;



    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y , transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y , transform.position.z);
        }
        float Horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Horizontal * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Projectileprefab,transform.position , Projectileprefab.transform.rotation);
        }
    }


}
