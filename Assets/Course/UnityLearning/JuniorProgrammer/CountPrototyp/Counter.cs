using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public GameObject Box;
    public Text CounterText;

    private int Count = 0;
    private Vector3 Apose;
    private Vector3 Bpose;

    private void Start()
    {
        Count = 0;
        Apose = Bpose = Box.transform.position;
        Apose = new Vector3(Apose.x + 30 , Apose.y , Apose.z );
        Bpose = new Vector3(Bpose.x -30 , Bpose.y , Bpose.z );
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Count : " + Count;
    }

    public void Teleport(float a1)
    {
        Box.transform.position = Vector3.Lerp( Apose , Bpose , a1 );
    }


}
