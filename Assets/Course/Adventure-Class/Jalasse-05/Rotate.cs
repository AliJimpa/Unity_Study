using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed;
    CharacterController character;

    // Start is called before the first frame update
    void Start()
    {
        character=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotate = Input.GetAxis("Horizontal");
        float movement1 = Input.GetAxis("Vertical");
        //transform.Rotate(0,rotate*speed,0);
        //transform.Translate(Vector3.forward*movement1* Time.deltaTime);
        Vector3 movement2=transform.right*rotate+transform.forward*movement1;

        character.Move(movement2);

        

    }
}
