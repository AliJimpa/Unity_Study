using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateLocation : MonoBehaviour
{
    
    public GameObject myPrefab;
    public KeyCode SelectInput;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update ()
    {
        if (Input.GetKeyDown(SelectInput))
        {
            Instantiate(myPrefab, transform.position , transform.rotation);
        }
    }

}
