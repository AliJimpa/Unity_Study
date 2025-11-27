using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player;
    public Transform Pos1;
    public Transform Pos2;
    public KeyCode Inpt;


    private bool isfirstenter = true;



    void LateUpdate()
    {
        //transform.position = player.transform.position + offset;
        if (isfirstenter)
        {
            transform.position = Pos1.position;
        }
        else
        {
            transform.position = Pos2.position;
        }

        if (Input.GetKeyDown(Inpt))
        {
            if (isfirstenter)
            {
                isfirstenter = false;
                Trans2(Pos2);
            }
            else
            {
                isfirstenter = true;
                Trans2(Pos1);
            }
        }
    }


    public void Trans2(Transform trans)
    {
        transform.position = trans.position;
        transform.rotation = trans.rotation;
        transform.localScale = trans.localScale;
    }



}
