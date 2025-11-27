using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Camera : MonoBehaviour
{
    public GameObject Camera;
    public List<Transform> WE =  null;

    public void CC(int PoseNumber)
    {
        SetPositionAndRotation(WE[PoseNumber].position , WE[PoseNumber].rotation);
    }

    public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
    {
        Camera.transform.position = position;
        Camera.transform.rotation = rotation;
    }


}
